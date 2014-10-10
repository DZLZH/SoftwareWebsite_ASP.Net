using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class imglist : System.Web.UI.Page
{
    public string typename = string.Empty;
    NewsSolution.BLL.hnf_n_type bhl = new NewsSolution.BLL.hnf_n_type();
    NewsSolution.BLL.hnf_news bhi = new NewsSolution.BLL.hnf_news();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    protected void BindData()
    {

        //产品展示
        Common.BindRepeater(rptImageList, 6, " news_type=4 and news_isshow=1 order by news_createtime  desc");
        if (!string.IsNullOrEmpty(Request["tid"]))
        {
            string tid = Request["tid"].ToString();

            if (Common.IsNumberic(tid))
            {
                Title = Common.GetPageTitle();
                typename = bhl.GetModel(int.Parse(tid)).n_type_name;
                Common.PagerBind(rptImageList, bhi.GetList(" news_type=" + tid + " order by news_recommand desc"), AspNetPager1);
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