using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class index : System.Web.UI.Page
{
    public string pics = string.Empty;
    public string links = string.Empty;
    public string texts = string.Empty;
    public string des = string.Empty;
    public List<String> newspicid = new List<String>();
    public List<String> newspicimg = new List<String>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();

        }
        WebServices.InitalizeWebServices("20130");
    }
    protected void BindData()
    {
        NewsSolution.BLL.hnf_news bhn = new NewsSolution.BLL.hnf_news();
        string id = string.Empty;
        DataTable dt = new DataTable();
        
        //新闻中心
        Common.BindRepeater(rptXinwen, 5, " news_type=1 and news_isshow=1 order by news_recommand desc, news_createtime  desc");
        //行业动态
        Common.BindRepeater(Repeater1, 5, " news_type=10 and news_isshow=1  order by news_recommand desc, news_createtime desc");
   
      }
    }
    
