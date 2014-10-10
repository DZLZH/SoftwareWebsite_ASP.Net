using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class manger_downfile_addfile : basepage
{
    NewsSolution.BLL.hnf_filedown bn = new NewsSolution.BLL.hnf_filedown();
    NewsSolution.Model.hnf_filedown mn = new NewsSolution.Model.hnf_filedown();
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
            txtseotitle.Text = mn.down_seotitle.ToString();
            txtseokeyword.Text = mn.down_keyword.ToString();
            txtdescrib.Text = mn.down_describ.ToString();
            txtnewstitle.Text = mn.down_name.ToString();
            txturl.Text = mn.file_url.ToString();
            txtnewsread.Text = mn.down_times.ToString();
            if (mn.down_shenhe == 0)
            {
                chkhot.Checked = false;
            }
            else
            {
                chkhot.Checked = true;
            }
            if (mn.down_recommand == 0)
            {
                chkrem.Checked = false;
            }
            else
            {
                chkrem.Checked = true;
            }
            lbladdtime.Text = mn.down_createtime.ToString();
            lblimg.Text = mn.file_name;
            txtContent.Value = mn.file_content.ToString();
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
                mn.down_createtime = DateTime.Now;
                mn.file_url = txturl.Text.Trim();
                if (txtContent.Value == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('请填定一些关于文件的简介')", true);
                    return;
                }
                mn.file_content = txtContent.Value.Trim();
                mn.down_describ = txtdescrib.Text.Trim();
                if (chkhot.Checked == true)
                {
                    mn.down_shenhe = 1;
                }
                else
                {
                    mn.down_shenhe = 0;
                }
                if (chkrem.Checked == true)
                {
                    mn.down_recommand = 1;
                }
                else
                {
                    mn.down_recommand = 0;
                }
                if (lblimg.Text != "")
                {
                    mn.file_name = lblimg.Text.Trim();
                }
                mn.down_keyword = txtseokeyword.Text.Trim();
                mn.down_name = txtnewstitle.Text.Trim();
                mn.down_times = Convert.ToInt32(txtnewsread.Text.Trim());
                mn.down_seotitle = txtseotitle.Text.Trim();
                bn.Add(mn);
                basepage bp = new basepage();
                string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "上传文件成功！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            }
            else
            {
                mn = bn.GetModel(Convert.ToInt32(hidetypeid.Value));
                txturl.Text = mn.file_url.ToString();
                lblimg.Text = mn.file_name.ToString();
                if (txtContent.Value == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('请填定一些关于文件的简介')", true);
                    return;
                }
                mn.file_content = txtContent.Value.Trim();
                mn.down_describ = txtdescrib.Text.Trim();
                if (chkhot.Checked == true)
                {
                    mn.down_shenhe = 1;
                }
                else
                {
                    mn.down_shenhe = 0;
                }
                if (chkrem.Checked == true)
                {
                    mn.down_recommand = 1;
                }
                else
                {
                    mn.down_recommand = 0;
                }
                mn.down_keyword = txtseokeyword.Text.Trim();
                mn.down_name = txtnewstitle.Text.Trim();
                mn.down_times = Convert.ToInt32(txtnewsread.Text.Trim());
                mn.down_seotitle = txtseotitle.Text.Trim();
                mn.down_id = Convert.ToInt32(hidetypeid.Value);
                bn.Update(mn);
                basepage bp = new basepage();
                string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "修改上传文件成功！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            }
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('操作成功');location.href('filelist.aspx');", true);

        }
        catch
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('操作失败')", true);
            basepage bp = new basepage();
            string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "上传文件失败！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
            Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            return;
        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/manger/downfile/filelist.aspx");
    }
    protected void upbtn_Click(object sender, EventArgs e)
    {
        if (lblimg.Text == "")
        {
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
                    upfile.PostedFile.SaveAs(Server.MapPath("~/Files/" + newname));
                    this.lblimg.Text = newname;
                }
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
        string[] exts = {".doc",".xls",".rar",".zip",".docx",".ppt",".png",".gif",".jpeg",".jpg",".txt"};
        foreach (string ext in exts)
        {
            if(str==ext)
            {
                flag = true;
            }
        }
        return flag;
    }    
    
}