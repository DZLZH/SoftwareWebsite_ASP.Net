using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class manger_left : basepage
{
    protected void Page_Load(object sender, EventArgs e)
    {
         //1、超级管理员，2、内容管理员
        if (Session["role"] != null && (string)Session["role"] != "")
        {
            Bind(Session["role"].ToString());
        }
    }
    protected void Bind(string role)
    {
        switch (role)
        {
            case "1"://超级管理员具有后台所有的权限，所有菜单都可见
                break;
            case "2"://内容管理员
                divadmin.Visible = false;
                hadmin.Visible = false;
                hpw.Visible = false;
                //日志管理不能用
                RZ.Visible = false;
                divrz.Visible = false;
                break;
         
        }
       
        }
}