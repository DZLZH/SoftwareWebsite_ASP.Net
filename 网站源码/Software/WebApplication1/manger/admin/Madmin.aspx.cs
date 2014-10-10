using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class manger_admin_Madmin : System.Web.UI.Page
{
    NewsSolution.BLL.hnf_adminuser admin = new NewsSolution.BLL.hnf_adminuser();
    NewsSolution.Model.hnf_adminuser madmin = new NewsSolution.Model.hnf_adminuser();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Session["Mname"].ToString()))
        {
            ds = admin.GetList("user_name='" + Session["Mname"].ToString() + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                HiddenField1.Value = ds.Tables[0].Rows[0][0].ToString();//用户id
            }
            if (Session["Mname"].ToString() == "admin")
            {
                HiddenField1.Value = "1";
            }
        }
        if (!IsPostBack)
        {
            bindate();
        }
    }
    protected void bindate()
    {
        if (!string.IsNullOrEmpty(HiddenField1.Value) && HiddenField1.Value != "1")
        {
            dldtype.DataSource = admin.GetList("1=1 order by user_logintime desc");
            dldtype.DataBind();
        }
        else
        {
            dldtype.DataSource = admin.GetList("1=1 order by user_logintime desc");
            dldtype.DataBind();
        }
    }
    protected void dldtype_CancelCommand(object source, DataListCommandEventArgs e)
    {
        dldtype.EditItemIndex = -1;
        bindate();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(HiddenField1.Value))
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('您没有此权限！')</script>");
            return;
        }
        if (txtname.Value == "" || txtpwd.Value == "")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('用户名或密码不能为空')</script>");
        }
        else
        {
            madmin.user_name = txtname.Value.Trim();
            madmin.user_password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(txtpwd.Value.Trim(), "md5");
            madmin.user_logintime = DateTime.Now;
            madmin.user_createtime = DateTime.Now;
            madmin.user_ip = Request.ServerVariables.Get("Remote_Addr").ToString();
            madmin.user_role = Convert.ToInt32(ddrole.SelectedValue.ToString());
            admin.Add(madmin);
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('添加成功')</script>");
            bindate();
            //basepage bp = new basepage();
            //string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "添加用户成功！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
            //Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);

        }
        txtname.Value = "";
        txtpwd.Value = "";
    }
    protected void dldtype_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        int id = Convert.ToInt32(dldtype.DataKeys[e.Item.ItemIndex]);
        if (HiddenField1.Value == "1")
        {
            if (id == 1)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('管理员admin不能删除！')</script>");
                return;
            }
            admin.Delete(id);
        }
        else if (HiddenField1.Value != "")
        {
            ds = admin.GetList("user_id=" + HiddenField1.Value + " order by user_logintime desc");
            if (id.ToString() == ds.Tables[0].Rows[0][0].ToString())
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('管理员自己不能删除自己！')</script>");
                return;
            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('管理员admin不能删除！')</script>");
            return;
        }
        admin.Delete(id);
        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('删除成功')</script>");
        bindate();
    }
    protected void dldtype_EditCommand(object source, DataListCommandEventArgs e)
    {
        dldtype.EditItemIndex = e.Item.ItemIndex;
        bindate();
    }
    protected void dldtype_UpdateCommand(object source, DataListCommandEventArgs e)
    {
        int id = Convert.ToInt32(dldtype.DataKeys[e.Item.ItemIndex]);
        string u = ((TextBox)e.Item.FindControl("txtuser")).Text.Trim();
        string p = ((TextBox)e.Item.FindControl("txtpass")).Text.Trim();
        if (p == "")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('密码不能为空')</script>");
            return;
        }
        madmin = admin.GetModel(id);
        madmin.user_name = u;
        madmin.user_password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(p, "md5");
        admin.Update(madmin);
        Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('更新成功')</script>");
        dldtype.EditItemIndex = -1;
        bindate();
        //basepage bp = new basepage();
        //string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "修改用户成功！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
        //Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
    }
    
}
