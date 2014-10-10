using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NewsSolution.BLL;

public partial class content : System.Web.UI.Page
{
    public string id = "";
    public string typename = string.Empty;
    NewsSolution.BLL.hnf_news bhn = new NewsSolution.BLL.hnf_news();
    NewsSolution.Model.hnf_news mhn = new NewsSolution.Model.hnf_news();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            BindData();
            if (typename.Trim()=="新闻中心")
            {
               id="1";
            }
            else if (typename.Trim()=="行业动态")
            {
                id="10";
            }
            else if (typename.Trim() == "在线学习")
            {
                id = "3";
            }
            else if (typename.Trim() == "职业素养")
            {
                id = "4";
            }
            else if (typename.Trim() == "项目展示")
            {
                id = "5";
            }
            img.ImageUrl = "~/image/"+id+".png";
        }
    }
    protected void BindData()
    {

        if (!string.IsNullOrEmpty(Request["nid"]))
        {
            string nid = Request["nid"];
            if (bhn.Exists(int.Parse(nid)))
            {
                mhn = bhn.GetModel(int.Parse(nid));
                litNewsTitle.Text = mhn.news_name;
                //litNewsComeFrom.Text = mhn.news_comefrom;
                litNewsTime.Text = mhn.news_createtime.Value.ToString("yyyy-MM-dd");
                litNewsContent.Text = mhn.news_content;
                int seetimes = mhn.news_seetime.Value;
                seetimes = seetimes + 1;
                mhn.news_seetime = seetimes;
                litNewsClicks.Text = seetimes.ToString();
                typename = GetType(mhn.news_type.Value);
                bhn.Update(mhn);
                Title = Common.GetPageTitle();
            }
            else
            {
                Common.MsgBox2("参数不合法！", "index.aspx", Page);
            }
        }
        else
        {
            Common.MsgBox2("无效参数！", "index.aspx", Page);
        }
    }

    protected string GetId(string id, string type, bool isUp)
    {
        string retid = string.Empty;
        DataSet ds = new DataSet();
        ds = bhn.GetIdList(" news_isshow=1 and news_type=" + type + " order by news_createtime desc");
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i][0].ToString() == id)
                {
                    if (isUp && i > 0)
                    {
                        retid = ds.Tables[0].Rows[i - 1][0].ToString();
                        break;
                    }
                    if (!isUp && i < ds.Tables[0].Rows.Count - 1)
                    {
                        retid = ds.Tables[0].Rows[i + 1][0].ToString();
                        break;
                    }
                }
            }
        }
        return retid;
    }
    protected string GetType(int id)
    {
        NewsSolution.BLL.hnf_n_type hbt = new NewsSolution.BLL.hnf_n_type();
        return hbt.GetModel(id).n_type_name;
    }

}