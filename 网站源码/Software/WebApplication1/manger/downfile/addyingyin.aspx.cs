using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class manger_downfile_addyingyin :basepage
{
    NewsSolution.BLL.hnf_news bn = new NewsSolution.BLL.hnf_news();
    NewsSolution.Model.hnf_news mn = new NewsSolution.Model.hnf_news();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            this.hidetypeid.Value = Convert.ToString(Request.QueryString["id"]);
        }
        else
        {
            this.hidetypeid.Value = "0";
        }
        if (!IsPostBack)
        {
            binddate();
        }
    }
    protected void binddate()
    {
        if (hidetypeid.Value != "0")
        {
            mn = bn.GetModel(Convert.ToInt32(hidetypeid.Value));
            txtseotitle.Text = mn.news_seotitle.ToString();
            txtseokeyword.Text = mn.news_keyword.ToString();
            txtdescrib.Text = mn.news_describ.ToString();
            txtnewstitle.Text = mn.news_name.ToString();
            //txturl.Text = mn.file_url.ToString();
            txtnewsread.Text = mn.news_seetime.ToString();
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
            lblimg.Text = mn.news_name;
            txtContent.Value = mn.news_content.ToString();
        }
        else
        {
            lbladdtime.Text = DateTime.Now.ToString();
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (hidetypeid.Value == "0")
            {
                mn.news_createtime = DateTime.Now;
                //mn.file_url = txturl.Text.Trim();
                if (txtContent.Value == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('请填定一些关于文件的简介')", true);
                    return;
                }
                mn.news_content = txtContent.Value.Trim();
                mn.news_describ = txtdescrib.Text.Trim();
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
                if (lblimg.Text != "")
                {
                    mn.news_name = lblimg.Text.Trim();
                }
                mn.news_keyword = txtseokeyword.Text.Trim();
                mn.news_name = txtnewstitle.Text.Trim();
                mn.news_seetime = Convert.ToInt32(txtnewsread.Text.Trim());
                mn.news_seotitle = txtseotitle.Text.Trim();
                bn.Add(mn);
                //basepage bp = new basepage();
                //string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "上传文件成功！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
                //Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            }
            else
            {
                mn = bn.GetModel(Convert.ToInt32(hidetypeid.Value));
                //txturl.Text = mn.file_url.ToString();
                lblimg.Text = mn.news_name.ToString();
                if (txtContent.Value == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('请填定一些关于文件的简介')", true);
                    return;
                }
                mn.news_content = txtContent.Value.Trim();
                mn.news_describ = txtdescrib.Text.Trim();
                if (chkhot.Checked == true)
                {
                    mn.news_isshow = 1;
                }
                else
                {
                    mn.news_isshow = 1;
                }
                if (chkrem.Checked == true)
                {
                    mn.news_recommand = 1;
                }
                else
                {
                    mn.news_recommand = 0;
                }
                mn.news_keyword = txtseokeyword.Text.Trim();
                mn.news_name = txtnewstitle.Text.Trim();
                mn.news_seetime = Convert.ToInt32(txtnewsread.Text.Trim());
                mn.news_seotitle = txtseotitle.Text.Trim();
                mn.news_id = Convert.ToInt32(hidetypeid.Value);
                bn.Update(mn);
                //basepage bp = new basepage();
                //string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "修改上传文件成功！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
                //Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            }
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('操作成功');location.href('yingyinkulist.aspx');", true);

        }
        catch
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('操作失败')", true);
            //basepage bp = new basepage();
            //string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "上传文件失败！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
            //Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            return;
        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/manger/downfile/yingyin.aspx");
    }
    protected void upbtn_Click(object sender, EventArgs e)
    {
        if (lblimg.Text == "")
        {
            string imgname = this.upfile.PostedFile.FileName.Substring(this.upfile.PostedFile.FileName.LastIndexOf('\\') + 1);
            string Extension = System.IO.Path.GetExtension(imgname).ToLower();
            if (IsExtension(Extension))
            {
                //if (upfile.PostedFile.ContentLength > 1024000)
                //{
                //    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('上传文件的大小不能超过1M！')</script>");
                //}

                string newname = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + Extension;
                upfile.PostedFile.SaveAs(Server.MapPath("~/Files/" + newname));
                this.lblimg.Text = newname;

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('上传文件格式错误')</script>");
            }
        }
        else
        {
            if (System.IO.File.Exists(Server.MapPath("~/Files/") + lblimg.Text))
            {
                System.IO.File.Delete(Server.MapPath("~/Files/") + lblimg.Text);
            }
            string imgname = this.upfile.PostedFile.FileName.Substring(this.upfile.PostedFile.FileName.LastIndexOf('\\') + 1);
            string Extension = System.IO.Path.GetExtension(imgname).ToLower();
            if (IsExtension(Extension))
            {
                if (upfile.PostedFile.ContentLength > 1024000)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('上传文件的大小不能超过1M！')</script>");
                }
                else
                {
                    string newname = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + Extension;
                    //this.picFile.PostedFile.SaveAs(Server.MapPath("~/imguploads/") + newname);
                    upfile.PostedFile.SaveAs(Server.MapPath("~/Files/" + newname));
                    this.lblimg.Text = newname;
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('上传文件格式错误')</script>");
            }
        }
    }
        protected bool IsExtension(string str)
    {
        bool flag = false;
        string[] exts = { ".mp3", ".rm", ".rmvb", ".mtv", ".mpg", ".mpe", ".mpa", ".mpr", ".jpeg", ".jpg", ".txt" ,".gif"};
        foreach (string ext in exts)
        {
            if (str == ext)
            {
                flag = true;
            }
        }
        return flag;
    }
}