using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class manger_base_loglist :basepage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            binddata();
        }
    }
    protected void binddata()
    {
        string sql = "";
        sql += "select * from hnf_loginlog ";
        if (key.Value.Trim() != "")
        {
            sql += "where log_note like '%" + key.Value.Trim() + "%' ";
        }
        sql += " order by log_id desc";
        DataSet ds = new DataSet();
        ds = Maticsoft.DBUtility.DbHelperSQL.Query(sql);
        AspNetPager1.RecordCount = ds.Tables[0].Rows.Count;
        PagedDataSource pds = new PagedDataSource();
        pds.AllowPaging = true;
        pds.DataSource = ds.Tables[0].DefaultView;
        pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
        pds.PageSize = AspNetPager1.PageSize;
        rptNewslist.DataSource = pds;
        rptNewslist.DataBind();
    }
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        binddata(); 
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        binddata();
    }
    protected void rptNewslist_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "delete")
        {
            int id = Convert.ToInt32(e.CommandArgument);
            Maticsoft.DBUtility.DbHelperSQL.ExecuteSql("delete from hnf_loginlog where log_id=" + id);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('删除成功')</script>");

        }
    }
}