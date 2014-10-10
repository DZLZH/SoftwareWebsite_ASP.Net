using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

public partial class manger_news_newstype :basepage
{
    NewsSolution.BLL.hnf_n_type bntype = new NewsSolution.BLL.hnf_n_type();
    NewsSolution.Model.hnf_n_type mntype = new NewsSolution.Model.hnf_n_type();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (ConfigurationManager.ConnectionStrings["addntype"].ToString() == "0")
        {
            btnAdd.Enabled = false;
            btnAdd.ToolTip = "无权添加分类";
        }
        else
        {
            btnAdd.Enabled = true;
        }
        if (!IsPostBack)
        {
            binddate();
        }
    }
    protected void binddate()
    {
        DataSet ds = new DataSet();
        ds = bntype.GetList("1=1 order by n_type_root,n_type_strsort,n_type_sort desc");
        NFtype.DataSource = ds;
        NFtype.DataBind();
    }

    //辅助方法

    protected string hh(object a1, object a2)
    {
        string a = a1.ToString();
        int b = Convert.ToInt32(a2);
        if (b > 0)
        {
            string kg = "";
            string g = "|-";
            for (int i = 1; i <= b; i++)
            {
                kg += "　";
            }
            return kg + g + a;
        }
        else
        {
            return "<b>" + a + "</b>";
        }
    }

    protected string parentID(object a)
    {
        int b = Convert.ToInt32(a);
        DataSet ds = new DataSet();
        string temp = string.Empty;
        if (b != 0)
        {
            ds = bntype.GetList("n_type_id=" + b.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                temp = ds.Tables[0].Rows[0]["n_type_name"].ToString();
            }
        }
        else
        {
            temp = "根节点";
        }
        return temp;
    }
    protected void NFtype_ItemCommand(object source, DataListCommandEventArgs e)
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
            bntype.UpdOrder(Id, Item - 1);
            for (int i = 0; i < NFtype.Items.Count; i++)
            {
                if (i == Item) continue;
                else
                {
                    int _fid = Convert.ToInt32((NFtype.Items[i].FindControl("hdfId") as HiddenField).Value);
                    if (i == (Item - 1)) bntype.UpdOrder(_fid, Item);
                    else bntype.UpdOrder(_fid, i);
                }
            }
        }
        else if (d == "OrderDown")
        {
            if (Item == (NFtype.Items.Count - 1)) return;
            bntype.UpdOrder(Id, Item + 1);
            for (int i = 0; i < NFtype.Items.Count; i++)
            {
                if (i == Item) continue;
                else
                {
                    int _fid = Convert.ToInt32((NFtype.Items[i].FindControl("hdfId") as HiddenField).Value);
                    if (i == (Item + 1)) bntype.UpdOrder(_fid, Item);
                    else bntype.UpdOrder(_fid, i);
                }
            }
        }
        else if (d == "delete")
        {
            if (ConfigurationManager.AppSettings["addntype"].ToString() == "0")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('无权删除')", true);
            }
            else
            {
                bntype.Delete(Id);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('记录删除成功')", true);
            }
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
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql("UPDATE hnf_n_type SET n_type_isshow='" + _Value + "' WHERE n_type_id=" + Id);
            }
            catch (Exception)
            {
                return;
            }
        }
        binddate();
    }
    protected void btnAdd_Click1(object sender, EventArgs e)
    {
        Response.Redirect("~/manger/news/addnewstype.aspx");
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
}