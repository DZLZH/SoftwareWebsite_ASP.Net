using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class manger_downfile_filelist :basepage
{
    DataSet ds = new DataSet();
    NewsSolution.Model.hnf_filedown mn = new NewsSolution.Model.hnf_filedown();
    NewsSolution.BLL.hnf_filedown bn = new NewsSolution.BLL.hnf_filedown();
    StringBuilder sb = new StringBuilder();
    PagedDataSource ps = new PagedDataSource();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddate();
        }
    }
    protected string Getshenhe(object obj)
    {
        bool boo = Convert.ToBoolean(obj);
        return boo ? "√" : "×";
    }
    protected System.Drawing.Color GetshenheColor(object obj)
    {
        bool boo = Convert.ToBoolean(obj);
        return boo ? System.Drawing.Color.Green : System.Drawing.Color.Red;
    }

    protected string Getrem(object obj)
    {
        bool boo = Convert.ToBoolean(obj);
        return boo ? "√" : "×";
    }
    protected System.Drawing.Color GetremColor(object obj)
    {
        bool boo = Convert.ToBoolean(obj);
        return boo ? System.Drawing.Color.Green : System.Drawing.Color.Red;
    }

    protected void binddate()
    {
        sb.Append("1=1");
        if (chkshow.Checked == true)
        {
            sb.Append(" and down_shenhe=1");
        }
        if (chkrem.Checked == true)
        {
            sb.Append(" and down_recommand=1");
        }
        if (this.key.Value != "")
        {
            sb.Append(" and down_name like '%" + key.Value.Trim() + "%'");
        }
        sb.Append(" order by down_createtime desc");
        ds = bn.GetList(sb.ToString());
        ps.DataSource = ds.Tables[0].DefaultView;
        ps.AllowPaging = true;
        AspNetPager1.RecordCount = ds.Tables[0].Rows.Count;
        ps.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
        ps.PageSize = AspNetPager1.PageSize;
        this.rptNewslist.DataSource = ps;
        this.rptNewslist.DataBind();
    }
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        binddate();
    }
    protected void rptNewslist_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "delete")
        {
            int id = Convert.ToInt32(e.CommandArgument);

            if (System.IO.File.Exists(Server.MapPath("~/downfile/" + bn.GetModel(id).file_name)))
            {
                System.IO.File.Delete(Server.MapPath("~/downfile/" + bn.GetModel(id).file_name));
            }
            bn.Delete(id);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('删除成功')</script>");

        }
        else if (e.CommandName == "rem")
        {
            try
            {
                string _Value = getrem(Convert.ToInt32(e.CommandArgument.ToString()));
                if (_Value == "0")
                {
                    _Value = "1";
                }
                else
                {
                    _Value = "0";
                }
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql("UPDATE hnf_filedown SET down_recommand=" + _Value + " WHERE down_id=" + e.CommandArgument.ToString());
            }
            catch
            {
                return;
            }
        }
        else
        {
            try
            {
                string _Value = "0";
                if (e.CommandName.ToString() == "0")
                {
                    _Value = "1";
                }
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql("UPDATE hnf_filedown SET down_shenhe=" + _Value + " WHERE down_id=" + e.CommandArgument.ToString());
            }
            catch (Exception)
            {
                return;
            }
        }
        binddate();
    }
    protected string getrem(int id)
    {
        string num = "0";
        mn = bn.GetModel(id);
        if (mn != null)
        {
            num = mn.down_recommand.ToString();
        }
        return num;

    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        binddate();
    }
}