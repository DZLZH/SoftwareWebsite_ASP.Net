using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NewsSolution.BLL;
using NewsSolution.Model;
using System.Text;

public partial class manger_news_newslist : basepage
{
    public string typeid = string.Empty;
    DataSet ds = new DataSet();
    NewsSolution.Model.hnf_news mn = new NewsSolution.Model.hnf_news();
    NewsSolution.BLL.hnf_news bn = new NewsSolution.BLL.hnf_news();
    NewsSolution.BLL.hnf_n_type bntype = new NewsSolution.BLL.hnf_n_type();
    StringBuilder sb = new StringBuilder();
    PagedDataSource ps = new PagedDataSource();
    public string tid = string.Empty;
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

        if (Request.QueryString["tid"] != null)
        {
            typeid = Request["tid"];

            sb.Append("1=1");
            sb.Append(" and news_type=" + typeid);
            lbltitle.Text = getType(typeid);
            if (chkshow.Checked == true)
            {
                sb.Append(" and news_isshow=1");
            }
            if (chkrem.Checked == true)
            {
                sb.Append(" and news_recommand=1");
            }
            if (this.key.Value != "")
            {
                sb.Append(" and news_name like '%" + key.Value.Trim() + "%'");
            }
            sb.Append("  order by news_sort desc,news_createtime desc");
            Session["sqlSb"] = sb.ToString();
            ds = bn.GetList(sb.ToString());
            ps.DataSource = ds.Tables[0].DefaultView;
            ps.AllowPaging = true;
            AspNetPager1.RecordCount = ds.Tables[0].Rows.Count;
            ps.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            ps.PageSize = AspNetPager1.PageSize;
            this.rptNewslist.DataSource = ps;
            this.rptNewslist.DataBind();
            if (AspNetPager1.CurrentPageIndex == 1)
            {
                if (rptNewslist.Items.Count > 0)
                {
                    (rptNewslist.Items[0].FindControl("ibtUp") as ImageButton).ImageUrl = "../images/order_up_no.gif";
                    (rptNewslist.Items[0].FindControl("idTop") as ImageButton).ImageUrl = "../images/order_top_no.gif";
                }
            }
            if (AspNetPager1.CurrentPageIndex == AspNetPager1.PageCount)
            {
                if (rptNewslist.Items.Count > 0)
                {
                    (rptNewslist.Items[rptNewslist.Items.Count - 1].FindControl("ibtDown") as ImageButton).ImageUrl = "../images/order_down_no.gif";
                    (rptNewslist.Items[rptNewslist.Items.Count - 1].FindControl("idEnd") as ImageButton).ImageUrl = "../images/order_end_no.gif";
                    //(rptNewslist.Items[rptNewslist.Items.Count - 1].FindControl("idEnd") as LinkButton).Enabled = false;
                }
            }
        }
    }
    //private string Gettypes(string id)
    //{
    //    string types = null;
    //    NewsSolution.Model.hnf_n_type pmn = new NewsSolution.Model.hnf_n_type();
    //    pmn = bntype.GetModel(int.Parse(id));
    //    if (pmn.n_type_parentid == 0)
    //    {
    //        DataSet ds = bntype.GetList(" n_type_parentid=" + id);
    //        types = ds.Tables[0].Rows.Cast<DataRow>().Aggregate(types, (current, dr) => current + (dr[0] + ","));
    //        return types.Substring(0, types.Length - 1);
    //    }
    //    else
    //    {
    //        return id;
    //    }
    //}

    /// <summary>
    /// 获得类型名称
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    protected string getType(string id)
    {
        ds = bntype.GetList(" n_type_id=" + id);
        return ds.Tables[0].Rows[0]["n_type_name"].ToString();
    }
    //private void getParentList()
    //{
    //    DataTable tab = bntype.GetList("1=1 order by n_type_root,n_type_strsort").Tables[0];
    //    ddlftype.Items.Clear();
    //    ddlftype.Items.Add("选择新闻分类");
    //    ddlftype.Items[0].Value = "0";
    //    this.getTreeList(ddlftype, tab);
    //}

    protected void btnQuery_Click(object sender, EventArgs e)
    {
        binddate();
    }
    protected void rptNewslist_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string d = e.CommandName;
        string Id = "0";
        if (e.CommandArgument.ToString() != null)
        {
            Id = e.CommandArgument.ToString();
        }
        int Item = e.Item.ItemIndex;
        if (d == "OrderUp")
        {
            ChangeSort(Id, true);
        }
        else if (d == "OrderDown")
        {
            ChangeSort(Id, false);
        }
        else if (e.CommandName == "OrderTop")
        {
            SetTopOrEnd(Id, true);
        }
        else if (e.CommandName == "OrderEnd")
        {
            SetTopOrEnd(Id, false);
        }
        else if (e.CommandName == "delete")
        {
            int id = Convert.ToInt32(e.CommandArgument);
            string imagefile = getimagepath(id.ToString());
            if (System.IO.File.Exists(Server.MapPath("~/newsimg/") + imagefile))
            {
                System.IO.File.Delete(Server.MapPath("~/newsimg/" + imagefile));
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
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql("UPDATE hnf_news SET news_recommand=" + _Value + " WHERE news_id=" + e.CommandArgument.ToString());
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
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql("UPDATE hnf_news SET news_isshow=" + _Value + " WHERE news_id=" + e.CommandArgument.ToString());
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
            num = mn.news_recommand.ToString();
        }
        return num;
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        binddate();
    }
    public string getname(int id)
    {
        string name = string.Empty;
        DataSet ds = new DataSet();
        ds = bntype.GetList("n_type_id=" + id.ToString());
        if (ds.Tables[0].Rows.Count > 0)
        {
            name = ds.Tables[0].Rows[0]["n_type_name"].ToString();
        }
        return name;
    }

    protected string getimagepath(string id)
    {
        string pathfile = string.Empty;
        DataSet dsp = new DataSet();
        dsp = this.bn.GetList("news_id=" + Convert.ToInt32(id));
        if (dsp.Tables[0].Rows.Count > 0)
        {
            pathfile = dsp.Tables[0].Rows[0]["news_image"].ToString();
        }
        return pathfile;
    }

    private void ChangeSort(string id, bool isup)
    {
        NewsSolution.Model.hnf_news mn1 = new NewsSolution.Model.hnf_news();
        ds = bn.GetList(Session["sqlSb"].ToString());
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            if (id == ds.Tables[0].Rows[i][0].ToString())
            {
                mn = bn.GetModel(int.Parse(ds.Tables[0].Rows[i][0].ToString()));
                int count = mn.news_sort.Value;
                if (isup && i != 0)
                {
                    mn1 = bn.GetModel(int.Parse(ds.Tables[0].Rows[i - 1][0].ToString()));
                }
                else if (!isup && i != (ds.Tables[0].Rows.Count - 1))
                {
                    mn1 = bn.GetModel(int.Parse(ds.Tables[0].Rows[i + 1][0].ToString()));
                }
                mn.news_sort = mn1.news_sort;
                mn1.news_sort = count;
                bn.Update(mn);
                bn.Update(mn1);
                break;
            }
            continue;
        }
    }

    protected void SetTopOrEnd(string id, bool isTop)
    {
        ds = bn.GetList(Session["sqlSb"].ToString());
        int nid = int.Parse(id);
        mn = bn.GetModel(nid);
        int sort = mn.news_sort.Value;
        int count = 0;
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            if (mn.news_id.ToString() == ds.Tables[0].Rows[i][0].ToString())
            {
                count = i;
                break;
            }
        }
        if (isTop)
        {
            mn.news_sort = int.Parse(ds.Tables[0].Rows[0]["news_sort"].ToString());
            bn.Update(mn);
            for (int i = 0; i < count; i++)
            {
                int nid1 = int.Parse(ds.Tables[0].Rows[i][0].ToString());
                NewsSolution.Model.hnf_news mn3 = bn.GetModel(nid1);
                mn3.news_sort = mn3.news_sort - 1;
                bn.Update(mn3);
            }
        }
        else
        {
            mn.news_sort = int.Parse(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["news_sort"].ToString());
            bn.Update(mn);
            for (int i = count + 1; i < ds.Tables[0].Rows.Count; i++)
            {
                int nid1 = int.Parse(ds.Tables[0].Rows[i][0].ToString());
                NewsSolution.Model.hnf_news mn3 = bn.GetModel(nid1);
                mn3.news_sort = mn3.news_sort + 1;
                bn.Update(mn3);
            }
        }
    }

}