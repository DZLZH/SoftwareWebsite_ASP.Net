using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class manger_base_huandeng : basepage
{
    NewsSolution.Model.hnf_huandeng mhuan = new NewsSolution.Model.hnf_huandeng();
    NewsSolution.BLL.hnf_huandeng bhuan = new NewsSolution.BLL.hnf_huandeng();
    PagedDataSource ps = new PagedDataSource();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["tid"]))
        {
            HiddenField1.Value = Request["tid"];
        }
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

    protected void binddate()
    {
        string type = string.Empty;
        if (HiddenField1.Value != "")
        {
            type = " and huan_type=" + HiddenField1.Value;
            litAdd.Text =
                "<input id=\"Button1\" type=\"button\" value=\"添加幻灯\" style=\"height:25px\" onclick=\"location='addhuandeng.aspx?tid=" +
                HiddenField1.Value + "';\" />";
        }
        ds = bhuan.GetList("1=1 " + type + " order by huan_sort desc");
        ps.DataSource = ds.Tables[0].DefaultView;
        ps.AllowPaging = true;
        AspNetPager1.RecordCount = ds.Tables[0].Rows.Count;
        ps.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
        ps.PageSize = AspNetPager1.PageSize;
        rptNewslist.DataSource = ps;
        rptNewslist.DataBind();
        if (rptNewslist.Items.Count > 0)
        {
            (rptNewslist.Items[0].FindControl("ibtUp") as ImageButton).ImageUrl = "../images/order_up_no.gif";
            (rptNewslist.Items[rptNewslist.Items.Count - 1].FindControl("ibtDown") as ImageButton).ImageUrl = "../images/order_down_no.gif";
        }
    }
    protected void rptNewslist_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string d = e.CommandName;
        int Id = 0;
        if (e.CommandArgument.ToString() != null)
        {
            Id = Convert.ToInt32(e.CommandArgument.ToString());
        }
        int Item = e.Item.ItemIndex;
        if (d == "OrderUp")
        {
            if (Item == 0) return;
            bhuan.UpdOrder(Id, Item - 1);
            for (int i = 0; i < rptNewslist.Items.Count; i++)
            {
                if (i == Item) continue;
                else
                {
                    int _fid = Convert.ToInt32((rptNewslist.Items[i].FindControl("hdfId") as HiddenField).Value);
                    if (i == (Item - 1)) bhuan.UpdOrder(_fid, Item);
                    else bhuan.UpdOrder(_fid, i);
                }
            }
        }
        else if (d == "OrderDown")
        {
            if (Item == (rptNewslist.Items.Count - 1)) return;
            bhuan.UpdOrder(Id, Item + 1);
            for (int i = 0; i < rptNewslist.Items.Count; i++)
            {
                if (i == Item) continue;
                else
                {
                    int _fid = Convert.ToInt32((rptNewslist.Items[i].FindControl("hdfId") as HiddenField).Value);
                    if (i == (Item + 1)) bhuan.UpdOrder(_fid, Item);
                    else bhuan.UpdOrder(_fid, i);
                }
            }
        }
        else if (d == "delete")
        {
            string imagefile = getimagepath(Id.ToString());
            if (System.IO.File.Exists(Server.MapPath("~/uploads/") + imagefile))
            {
                System.IO.File.Delete(Server.MapPath("~/uploads/" + imagefile));
            }
            bhuan.Delete(Id);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('记录删除成功')", true);
        }
        else
        {
            try
            {
                string _Value = "0";
                if (d == "0")
                {
                    _Value = "1";
                }
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql("UPDATE hnf_huandeng SET huan_shenhe='" + _Value + "' WHERE huan_id=" + Id);
            }
            catch (Exception)
            {
                return;
            }
        }
        binddate();
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        binddate();
    }
    protected string getimagepath(string id)
    {
        string pathfile = string.Empty;
        DataSet dsp = new DataSet();
        dsp = this.bhuan.GetList("huan_id=" + id);
        if (dsp.Tables[0].Rows.Count > 0)
        {
            pathfile = dsp.Tables[0].Rows[0]["huan_image"].ToString();
        }
        return pathfile;
    }
}