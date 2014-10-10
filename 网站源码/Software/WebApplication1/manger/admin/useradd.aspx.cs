using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NewsSolution.BLL;

public partial class manger_admin_useradd :basepage
{
    NewsSolution.BLL.hnf_user bhu = new NewsSolution.BLL.hnf_user();
    NewsSolution.Model.hnf_user mhu = new NewsSolution.Model.hnf_user();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["id"]))
        {
            HiddenField1.Value = Request["id"];
            btnReSet.Visible = true;
        }
        else
        {
            HiddenField1.Value = "0";
            btnReSet.Visible = false;
        }
        if (!IsPostBack)
        {
            BindData();
        }
    }
    protected void BindData()
    {
        if (HiddenField1.Value != "0")
        {
            mhu = bhu.GetModel(int.Parse(HiddenField1.Value));
            txtLoginName.Text = mhu.user_name;
            txtTrueName.Text = mhu.user_truename;
            //txtPassword.Text = mhu.user_password;
            txtPassword.Visible = false;
            Label7.Text = mhu.user_password;
            //Label7.Visible = true;
            txtmail.Text = mhu.user_email;
            ckbIsEnAble.Checked = mhu.user_isable == 1 ? true : false;
            btnReSet.Visible = true;
            txtLoginName.Enabled = false;
        }
        else
        {
            btnReSet.Visible = false;
        }

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (HiddenField1.Value == "0")
            {
                mhu.user_addTime = DateTime.Now;
                mhu.user_answer = "";
                mhu.user_email = txtmail.Text.Trim();
                mhu.user_isable = ckbIsEnAble.Checked ? 1 : 0;
                mhu.user_name = txtLoginName.Text.Trim();
                mhu.user_truename = txtTrueName.Text.Trim();
                mhu.user_password = Common.Md5(txtPassword.Text.Trim());
                mhu.user_question = "";
                mhu.user_type = 0;
                if (IsExistNo(txtLoginName.Text.Trim()))
                {
                    Common.MsgBox0("学号" + txtLoginName.Text.Trim() + "已存在!", Page);
                    return;
                }
                bhu.Add(mhu);
                basepage bp = new basepage();
                string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "添加学生用户成功！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            }
            else
            {
                mhu = bhu.GetModel(int.Parse(HiddenField1.Value));
                mhu.user_email = txtmail.Text.Trim();
                mhu.user_isable = ckbIsEnAble.Checked ? 1 : 0;
                //mhu.user_name = txtLoginName.Text.Trim();
                mhu.user_truename = txtTrueName.Text.Trim();
                //mhu.user_password = txtPassword.Text.Trim();
                mhu.user_addTime = DateTime.Now;
                //if (IsExistNo(txtLoginName.Text.Trim()))
                //{
                //    Common.MsgBox0("学号" + txtLoginName.Text.Trim() + "已存在!", Page);
                //    return;
                //}
                bhu.Update(mhu);
                basepage bp = new basepage();
                string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "修改学生用户成功！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            }
            Common.MsgBox2("操作成功！", "userlist.aspx", Page);
        }
        catch (Exception)
        {
            Common.MsgBox0("操作失败！", Page);
            basepage bp = new basepage();
            string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "修改学生用户失败！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
            Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            return;
        }
    }
    protected void btnReSet_Click(object sender, EventArgs e)
    {
        try
        {
            if (HiddenField1.Value != "0")
            {
                string id = HiddenField1.Value;
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql("UPDATE hnf_user SET user_password='" +
                                                             Common.Md5("000000") + "' WHERE user_id=" + id);
                Common.MsgBox0("密码初始化成功！密码初始化为：000000！", Page);
                BindData();
            }
        }
        catch (Exception)
        {
            Common.MsgBox0("密码初始化失败！", Page);
            return;
        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("userlist.aspx");
    }
    protected bool IsExistNo(string no)
    {
        DataSet ds = new DataSet();
        ds = bhu.GetList(" user_name='" + no + "'");
        if (ds.Tables[0].Rows.Count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}