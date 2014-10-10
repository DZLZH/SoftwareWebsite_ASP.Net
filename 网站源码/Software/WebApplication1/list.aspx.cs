using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class list : System.Web.UI.Page
{
    public string typename = string.Empty;
    NewsSolution.BLL.hnf_news bhn = new NewsSolution.BLL.hnf_news();
    NewsSolution.Model.hnf_news mhn = new NewsSolution.Model.hnf_news();
    NewsSolution.BLL.hnf_n_type bnn = new NewsSolution.BLL.hnf_n_type();
    NewsSolution.Model.hnf_n_type mnn = new NewsSolution.Model.hnf_n_type();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            img.ImageUrl = "~/image/" + Request.QueryString["tid"] + ".png";
           BindData();
        }
    }
    
    protected void BindData()
    {
        //新闻列表
        Common.BindRepeater(rptNewsList, 16, " news_type=1 and news_isshow=1 order by news_recommand desc, news_createtime desc");
        
        if (!string.IsNullOrEmpty(Request["tid"]))
        {
            string tid = Request["tid"];
            if (Common.IsNumberic(tid))
            {
                if (bnn.Exists(int.Parse(tid)))
                {
                    typename = bnn.GetModel(int.Parse(tid)).n_type_name;
                    Title = Common.GetPageTitle();
                    DataSet ds = bhn.GetList(" news_type=" + tid + " order by news_createtime desc");
                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        Response.Redirect("content.aspx?nid=" + ds.Tables[0].Rows[0]["news_id"].ToString());
                    }
                    else
                    { Common.PagerBind(rptNewsList, ds, AspNetPager1); }
                }
                else Response.Redirect("index.aspx");
            }
            else
            {
                Common.MsgBox2("参数不合法！", "index.aspx", Page);
            }
        }
        else
        {
            Common.MsgBox2("无效的参数", "index.aspx", Page);
        }
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        BindData();
    }
}