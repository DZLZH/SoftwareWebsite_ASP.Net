using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NewsSolution.BLL;
using NewsSolution.Model;
using Maticsoft.DBUtility;
using System.Text.RegularExpressions;

public partial class manger_news_addnews : basepage
{
    NewsSolution.BLL.hnf_n_type bntype = new NewsSolution.BLL.hnf_n_type();
    NewsSolution.Model.hnf_n_type mntype = new NewsSolution.Model.hnf_n_type();
    NewsSolution.BLL.hnf_news bn = new NewsSolution.BLL.hnf_news();
    NewsSolution.Model.hnf_news mn = new NewsSolution.Model.hnf_news();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["id"]))
        {
            this.hidetypeid.Value = Request["id"];
        }
        else
        {
            this.hidetypeid.Value = "0";
        }
        if (!string.IsNullOrEmpty(Request["tid"]))
        {
            hdftype.Value = Request["tid"].ToString();
        }
        if (!IsPostBack)
        {
            getParentList();
            binddate();
        }
    }
    protected void binddate()
    {
        if (hidetypeid.Value != "0")
        {
            mn = bn.GetModel(Convert.ToInt32(hidetypeid.Value));
            txtnewstitle.Text = mn.news_name.ToString();
            ddlnewstype.SelectedValue = mn.news_type.ToString();
            txtnewscomefrom.Text = mn.news_comefrom.ToString();
            txtnewsread.Text = mn.news_seetime.ToString();
            hdftype.Value = mn.news_type.ToString();

            if (mn.news_isshow == 0)
            {
                chkhot.Checked = false;
            }
            else
            {
                chkhot.Checked = true;
            }
            if (mn.news_recommand == 0)
            {
                chkrem.Checked = false;
            }
            else
            {
                chkrem.Checked = true;
            }
            lbladdtime.Text = mn.news_createtime.ToString();
            lblaltertime.Text = mn.news_alertime.ToString();

            txtContent.Value = mn.news_content.ToString();
        }
        else
        {
            lbladdtime.Text = DateTime.Now.ToString();
            lblaltertime.Text = DateTime.Now.ToString();
            ddlnewstype.SelectedValue = hdftype.Value;
        }
    }
    private void getParentList()
    {
        DataTable tab = bntype.GetList("1=1 order by n_type_root,n_type_strsort").Tables[0];
        ddlnewstype.Items.Clear();
        ddlnewstype.Items.Add("选择新闻分类");
        ddlnewstype.Items[0].Value = "0";
        this.getTreeList(ddlnewstype, tab);
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (hidetypeid.Value == "0")
            {
                mn.news_alertime = DateTime.Parse(this.lblaltertime.Text);
                mn.news_comefrom = txtnewscomefrom.Text.Trim();
                if (txtContent.Value == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('新闻内容不能为空')", true);
                    return;
                }

                mn.news_image = regimgstr(txtContent.Value.Trim());

                mn.news_content = txtContent.Value.Trim();
                mn.news_createtime = DateTime.Parse(this.lbladdtime.Text);
                if (chkhot.Checked == true)
                {
                    mn.news_isshow = 1;
                }
                else
                {
                    mn.news_isshow = 0;
                }
                if (chkrem.Checked == true)
                {
                    mn.news_recommand = 1;
                }
                else
                {
                    mn.news_recommand = 0;
                }
                mn.news_name = txtnewstitle.Text.Trim();
                mn.news_seetime = Convert.ToInt32(txtnewsread.Text.Trim());
                if (ddlnewstype.SelectedValue == "0")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('选择新闻分类')", true);
                    return;
                }
                mn.news_type = Convert.ToInt32(ddlnewstype.SelectedValue);
                if (RadioButton1.Checked == true)
                {
                    mn.news_sort = 1;
                }
                else
                {
                    mn.news_sort = 0;
                }
                bn.Add(mn);
            }
            else
            {
                mn = bn.GetModel(Convert.ToInt32(hidetypeid.Value));
                mn.news_alertime = DateTime.Parse(this.lblaltertime.Text);
                mn.news_comefrom = txtnewscomefrom.Text.Trim();
                if (txtContent.Value == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('新闻内容不能为空')", true);
                    return;
                }

                 mn.news_image = regimgstr(txtContent.Value.Trim());

                mn.news_content = txtContent.Value.Trim();
                if (chkhot.Checked == true)
                {
                    mn.news_isshow = 1;
                }
                else
                {
                    mn.news_isshow = 0;
                }
                if (chkrem.Checked == true)
                {
                    mn.news_recommand = 1;
                }
                else
                {
                    mn.news_recommand = 0;
                }
                mn.news_name = txtnewstitle.Text.Trim();
                mn.news_seetime = Convert.ToInt32(txtnewsread.Text.Trim());
                if (ddlnewstype.SelectedValue == "0")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('选择新闻分类')", true);
                    return;
                }
                mn.news_type = Convert.ToInt32(ddlnewstype.SelectedValue);
                mn.news_id = Convert.ToInt32(hidetypeid.Value);
                mn.news_createtime = DateTime.Parse(this.lbladdtime.Text);
                bn.Update(mn);
            }
            basepage bp = new basepage();
            string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "添加或修改新闻成功！】','" + bp.GetIp() + "','" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('操作成功');location.href('newslist.aspx?tid=" + hdftype.Value + "');", true);
        }
        catch
        {
            basepage bp = new basepage();
            string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "添加或修改新闻失败！】','" + bp.GetIp() + "','" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"')";
            Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('操作失败')", true);
            return;
        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Newslist.aspx?tid=" + hdftype.Value);
    }
    protected string regimgstr(string content)
    {
        String regEx_img = "src=(\"/{1}|\'{1})([^\\[^>]+[gif|jpg|jpeg|bmp|png])";
        string imgstr = Regex.Match(content, regEx_img, RegexOptions.IgnoreCase).Value;
        imgstr = imgstr.Replace("src=\"/", "");
        string imgname = System.IO.Path.GetFileName(imgstr);
        return imgname;

    }

}