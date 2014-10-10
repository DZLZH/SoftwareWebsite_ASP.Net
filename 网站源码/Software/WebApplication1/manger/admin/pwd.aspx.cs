using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class manger_admin_pwd : basepage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        NewsSolution.BLL.hnf_adminuser admin = new NewsSolution.BLL.hnf_adminuser();
        NewsSolution.Model.hnf_adminuser madmin = new NewsSolution.Model.hnf_adminuser();
        string pwd_0 = pwd0.Value.Trim();
        pwd_0 = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pwd_0, "md5").ToString();
        DataSet ds = admin.GetList("user_name='" + Session["Mname"] + "' and user_password='" + pwd_0 + "'");
        int id = 0;
        try
        {
            id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
        }
        catch
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('原密码错误！')", true);
        }
        madmin = admin.GetModel(id);
        madmin.user_password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pwd1.Value.Trim(), "md5");
        try
        {
            admin.Update(madmin);

        }
        catch
        {
            basepage bp = new basepage();
            string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【用户" + Session["Mname"] + "修改密码成功！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
            Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('修改失败！')", true);
        }
        finally
        {
            basepage bp = new basepage();
            string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【用户" + Session["Mname"] + "修改密码失败！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
            Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('修改成功！')", true);
        }
    }
}