using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manger_base_addhuandeng :basepage
{
    NewsSolution.BLL.hnf_huandeng bhuan = new NewsSolution.BLL.hnf_huandeng();
    NewsSolution.Model.hnf_huandeng mhuan = new NewsSolution.Model.hnf_huandeng();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != "")
        {
            mhuan.huan_id = Convert.ToInt32(Request.QueryString["id"]);
        }
        else
        {
            mhuan.huan_id = 0;
        }
        if (!string.IsNullOrEmpty(Request["tid"]))
        {
            HiddenField1.Value = Request["tid"];
        }
        if (!IsPostBack)
        {
            bindpaymethod();
        }
    }
    protected void bindpaymethod()
    {
        if (mhuan.huan_id != 0)
        {
            mhuan = bhuan.GetModel(Convert.ToInt32(mhuan.huan_id));
            txtName.Text = mhuan.huan_title;
            txtpayname.Text = mhuan.huan_name;
            upimage.Text = mhuan.huan_image;
            CheckBox1.Checked = mhuan.huan_shenhe != 0;
            HiddenField1.Value = mhuan.huan_type.ToString();
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (mhuan.huan_id == 0)
            {
                if (upimage.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('幻灯图片不能为空')", true);
                    return;
                }
                mhuan.huan_title = txtName.Text.Trim();
                mhuan.huan_image = upimage.Text.Trim();
                mhuan.huan_name = txtpayname.Text.Trim();
                if (CheckBox1.Checked == false)
                {
                    mhuan.huan_shenhe = 0;
                }
                else
                {
                    mhuan.huan_shenhe = 1;
                }
                mhuan.huan_sort = 0;
                mhuan.huan_type = int.Parse(HiddenField1.Value);
                bhuan.Add(mhuan);
                basepage bp = new basepage();
                string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "添加flash图片成功！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            }
            else
            {
                mhuan = bhuan.GetModel(Convert.ToInt32(mhuan.huan_id));
                if (upimage.Text == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('幻灯图片不能为空')", true);
                    return;
                }
                mhuan.huan_title = txtName.Text.Trim();
                mhuan.huan_image = upimage.Text.Trim();
                mhuan.huan_name = txtpayname.Text.Trim();
                if (CheckBox1.Checked == false)
                {
                    mhuan.huan_shenhe = 0;
                }
                else
                {
                    mhuan.huan_shenhe = 1;
                }
                bhuan.Update(mhuan);
                basepage bp = new basepage();
                string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "修改flash图片成功！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            }

            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('保存成功');location.href('huandeng.aspx?tid=" + HiddenField1.Value + "');", true);
            return;
        }
        catch
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('保存失败')", true);
            basepage bp = new basepage();
            string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "添加或修改flash失败！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
            Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            return;
        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("huandeng.aspx?tid=" + HiddenField1.Value);
    }
    protected void btnupload_Click(object sender, EventArgs e)
    {
        if (upimage.Text == "")
        {
            string imgname = this.File1.PostedFile.FileName.Substring(this.File1.PostedFile.FileName.LastIndexOf('\\') + 1);
            string Extension = System.IO.Path.GetExtension(imgname).ToLower();
            if (Extension == ".gif" || Extension == ".jpg")
            {
                if (File1.PostedFile.ContentLength > 1024000)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('上传图片的大小不能超过1M！')</script>");
                }
                else
                {
                    string newname = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + Extension;
                    System.Drawing.Image img = System.Drawing.Image.FromStream(File1.PostedFile.InputStream);
                    img.Save(Server.MapPath("~/Files/" + newname), System.Drawing.Imaging.ImageFormat.Jpeg);
                    this.upimage.Text = newname;
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('上传图片格式错误')</script>");
            }
        }
        else
        {
            if (System.IO.File.Exists(Server.MapPath("~/Files/") + upimage.Text))
            {
                System.IO.File.Delete(Server.MapPath("~/Files/") + upimage.Text);
            }
            string imgname = this.File1.PostedFile.FileName.Substring(this.File1.PostedFile.FileName.LastIndexOf('\\') + 1);
            string Extension = System.IO.Path.GetExtension(imgname).ToLower();
            if (Extension == ".gif" || Extension == ".jpg")
            {
                if (File1.PostedFile.ContentLength > 1024000)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('上传图片的大小不能超过1M！')</script>");
                }
                else
                {
                    string newname = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + Extension;
                    //this.picFile.PostedFile.SaveAs(Server.MapPath("~/imguploads/") + newname);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(File1.PostedFile.InputStream);
                    img.Save(Server.MapPath("~/Files/" + newname), System.Drawing.Imaging.ImageFormat.Jpeg);
                    this.upimage.Text = newname;
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('上传图片格式错误')</script>");
            }
        }
    }
}