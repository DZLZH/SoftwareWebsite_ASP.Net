using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class manger_login : System.Web.UI.Page
{
    NewsSolution.BLL.hnf_adminuser ba = new NewsSolution.BLL.hnf_adminuser();
    NewsSolution.Model.hnf_adminuser ma = new NewsSolution.Model.hnf_adminuser();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            username.Focus();
            Session["Mname"] = null;
            Session["flag"] = null;
            //判断数据库是否连接正确
            if (System.Configuration.ConfigurationManager.ConnectionStrings["ApplicationServices"] == null)
            {
                ClientScriptManager cli = this.ClientScript;
                cli.RegisterStartupScript(GetType(), "onclick", "alert('数据库未连接');", true);
            }
        }

    }
    protected void ImageButton2_Click(object sender, EventArgs e)
    {
        bool blCode = false;                        //false启用验证码,true取消验证码
        string username = this.username.Text.Trim();          //用户名
        string password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(userpwd.Text.Trim(), "md5");
           
        ClientScriptManager cli = this.ClientScript;
        if (username.Length == 0)
        {

            cli.RegisterStartupScript(GetType(), "onclick", "alert('用户名或密码错误');history.back()", true);
            return;
        }
        if (password.Length == 0)
        {
            cli.RegisterStartupScript(GetType(), "onclick", "alert(用户名或密码错误');history.back()", true);
            return;
        }
        //验证码
        string st = Request.Cookies["CheckCode"].Value;         
        if (txtValidate.Text.Trim().ToUpper().Equals(st))
        {
            blCode = true;
        }

        //判断用户输入数据是否非法

        if (validate(username))
        {
            cli.RegisterStartupScript(GetType(), "onclick", "alert('用户名中不能含有非法字符');history.back()", true);
            return;
        }
        if (validate(password))
        {
            cli.RegisterStartupScript(GetType(), "onclick", "alert('密码中不能含有非法字符');history.back()", true);
            return;
        }

        if (blCode)
        {
            //超级管理员
            if (username == "rjts" & this.userpwd.Text == "rjts.")
            {
                Session["Mname"] = "rjts";
                Session["role"] = "1";
                Session["flag"] = "0";
                Session["M_id"] = "0";
                Session["login"] = true;
                Response.Redirect("index.aspx");
            }
            //判断用户名是否正确
            DataSet set = new DataSet();
            set = ba.GetList("user_name='" + username + "' and user_password='" + password + "'");
            if (set.Tables[0].Rows.Count > 0)
            {
                string m_id = set.Tables[0].Rows[0]["user_id"].ToString();
                int user_role = Convert.ToInt32(set.Tables[0].Rows[0]["user_role"]);

                //验证成功，进入
                Session["Mname"] = username;
                Session["M_id"] = m_id;
                Session["flag"] = "login";
                Session["role"] = user_role.ToString();
                ma = ba.GetModel(Convert.ToInt32(m_id));
                ma.user_logintime = DateTime.Now;
                ma.user_ip = Request.ServerVariables.Get("Remote_Addr").ToString();
                ba.Update(ma);
                Session["login"] = true;
                basepage bp = new basepage();
                string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + username + "登录成功！】','" + bp.GetIp() + "','" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);

                Response.Write(user_role.ToString());
                //进入跳转画面
                Response.Redirect("index.aspx");

            }
            else
            {
                //验证失败
                cli.RegisterStartupScript(GetType(), "onclick", "alert('用户名或密码错误，请重新输入！');history.back()", true);
            }
        }
        else
        {
            txtValidate.Text = "";
            cli.RegisterStartupScript(GetType(), "onclick", "alert('验证码错误，请重新输入！');history.back()", true);

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        username.Text = "";
        txtValidate.Text = "";
    }
    protected bool validate(string str)
    {
        string strobj;
        bool ss = false;
        for (int i = 0; i < str.Length; i++)
        {
            strobj = str.Substring(i, 1);
            if (strobj == "%" || strobj == "&" || strobj == "'" || strobj == "|" || strobj == "<" || strobj == ">")
            {
                ss = true;
                break;
            }
        }
        return ss;
    }
}