using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class manger_mlink_sitelink : basepage
{
    NewsSolution.BLL.hnf_link blink = new NewsSolution.BLL.hnf_link();
    NewsSolution.Model.hnf_link mlink = new NewsSolution.Model.hnf_link();
    DataSet ds = new DataSet();
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

    protected void binddate()
    {
        ds = blink.GetList("1=1 order by site_sort asc");
        ps.AllowPaging = true;
        ps.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
        ps.PageSize = AspNetPager1.PageSize;
        AspNetPager1.RecordCount = ds.Tables[0].Rows.Count;
        ps.DataSource = ds.Tables[0].DefaultView;
        this.rptNewslist.DataSource = ps;
        this.rptNewslist.DataBind();
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
            blink.UpdOrder(Id, Item - 1);
            for (int i = 0; i < rptNewslist.Items.Count; i++)
            {
                if (i == Item) continue;
                else
                {
                    int _fid = Convert.ToInt32((rptNewslist.Items[i].FindControl("hdfId") as HiddenField).Value);
                    if (i == (Item - 1)) blink.UpdOrder(_fid, Item);
                    else blink.UpdOrder(_fid, i);
                }
            }
        }
        else if (d == "OrderDown")
        {
            if (Item == (rptNewslist.Items.Count - 1)) return;
            blink.UpdOrder(Id, Item + 1);
            for (int i = 0; i < rptNewslist.Items.Count; i++)
            {
                if (i == Item) continue;
                else
                {
                    int _fid = Convert.ToInt32((rptNewslist.Items[i].FindControl("hdfId") as HiddenField).Value);
                    if (i == (Item + 1)) blink.UpdOrder(_fid, Item);
                    else blink.UpdOrder(_fid, i);
                }
            }
        }
        else if (d == "delete")
        {
            blink.Delete(Id);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('记录删除成功')", true);
        }
        else
        {
            try
            {
                //bool boo = !Convert.ToBoolean(Convert.ToInt32(d));
                //string _Value = boo.ToString();
                string _Value = "0";
                if (d == "0")
                {
                    _Value = "1";
                }
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql("UPDATE hnf_link SET site_shenhe='" + _Value + "' WHERE link_id=" + Id);
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
}