using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class manger_mlink_addlink : basepage
{
    NewsSolution.Model.hnf_link mlink = new NewsSolution.Model.hnf_link();
    NewsSolution.BLL.hnf_link blink = new NewsSolution.BLL.hnf_link();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        mlink.link_id = Request.QueryString["id"] != null ? Convert.ToInt32(Request.QueryString["id"]) : 0;
        if (!IsPostBack)
            binddate();
    }
    protected void binddate()
    {
        if (mlink.link_id != 0)
        {
            mlink = blink.GetModel(Convert.ToInt32(mlink.link_id));
            lbltime.Text = mlink.site_createtime.ToString();
            txtwebname.Text = mlink.site_name.ToString();
            txtwebsite.Text = mlink.site_url.ToString();
            if (mlink.site_logo != "")
            {
                upimage.Text = mlink.site_logo;
            }
            if (mlink.site_shenhe == 0)
            {
                chkisshow.Checked = false;
            }
            else
            {
                chkisshow.Checked = true;
            }
            hidesort.Value = mlink.site_sort.ToString();
        }
        else
        {
            lbltime.Text = DateTime.Now.ToString();
            btnSave.Text = "保存";
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (mlink.link_id == 0)
            {
                mlink.site_createtime = DateTime.Now;
                lbltime.Text = DateTime.Now.ToString();
                mlink.site_name = txtwebname.Text.Trim();
                mlink.site_logo = upimage.Text;
                mlink.site_url = txtwebsite.Text.Trim();
                mlink.site_sort = 0;
                if (chkisshow.Checked == false)
                {
                    mlink.site_shenhe = 0;
                }
                else
                {
                    mlink.site_shenhe = 1;
                }
                blink.Add(mlink);
            }
            else
            {
                mlink.site_createtime = DateTime.Now;
                lbltime.Text = DateTime.Now.ToString();
                mlink.site_name = txtwebname.Text.Trim();
                mlink.site_logo = upimage.Text;
                mlink.site_url = txtwebsite.Text.Trim();
                if (chkisshow.Checked == false)
                {
                    mlink.site_shenhe = 0;
                }
                else
                {
                    mlink.site_shenhe = 1;
                }
                mlink.site_sort = Convert.ToInt32(hidesort.Value);
                blink.Update(mlink);
            }
            basepage bp = new basepage();
            string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "修改或添加链接成功！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
            Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('保存成功');location.href('sitelink.aspx');", true);
        }
        catch
        {
            basepage bp = new basepage();
            string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "修改或添加链接失败！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
            Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('保存失败')", true);
            return;
        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/manger/mlink/sitelink.aspx");
    }
    protected void btnupload_Click(object sender, EventArgs e)
    {
        if (upimage.Text == "")
        {
            string imgname = File1.PostedFile.FileName.Substring(File1.PostedFile.FileName.LastIndexOf('\\') + 1);
            string Extension = System.IO.Path.GetExtension(imgname).ToLower();
            if (Extension == ".gif" || Extension == ".jpg" || Extension == ".png")
            {
                if (File1.PostedFile.ContentLength > 1024000)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('上传图片的大小不能超过1M！')</script>");
                }
                else
                {
                    string newname = DateTime.Now.Year + DateTime.Now.Month.ToString() + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + Extension;
                    System.Drawing.Image img = System.Drawing.Image.FromStream(File1.PostedFile.InputStream);
                    img.Save(Server.MapPath("~/Files/" + newname), System.Drawing.Imaging.ImageFormat.Jpeg);
                    upimage.Text = newname;
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('上传图片格式错误')</script>");
            }
        }
        else
        {
            if (System.IO.File.Exists(Server.MapPath("~/Files/") + upimage.Text))
            {
                System.IO.File.Delete(Server.MapPath("~/Files/") + upimage.Text);
            }
            var imgname = File1.PostedFile.FileName.Substring(File1.PostedFile.FileName.LastIndexOf('\\') + 1);
            var Extension = System.IO.Path.GetExtension(imgname).ToLower();
            if (Extension == ".gif" || Extension == ".jpg" || Extension == ".png")
            {
                if (File1.PostedFile.ContentLength > 1024000)
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('上传图片的大小不能超过1M！')</script>");
                }
                else
                {
                    var newname = DateTime.Now.Year + DateTime.Now.Month.ToString() + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + Extension;
                    //this.picFile.PostedFile.SaveAs(Server.MapPath("~/imguploads/") + newname);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(File1.PostedFile.InputStream);
                    img.Save(Server.MapPath("~/Files/" + newname), System.Drawing.Imaging.ImageFormat.Jpeg);
                    upimage.Text = newname;
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('上传图片格式错误')</script>");
            }
        }
    }
}