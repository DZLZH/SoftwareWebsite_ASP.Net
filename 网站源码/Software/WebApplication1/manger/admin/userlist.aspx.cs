using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewsSolution.BLL;
using System.Text;

public partial class manger_admin_userlist : basepage
{
    NewsSolution.BLL.hnf_user bhi = new NewsSolution.BLL.hnf_user();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    protected void BindData()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(" 1=1 ");
        if (chkshow.Checked)
        {
            sb.Append(" and user_isable=1 ");
        }
        //else
        //{
        //    sb.Append(" and user_isable=0 ");
        //}
        sb.Append(" order by user_id desc");
        Common.PagerBind(rptNewslist, bhi.GetList(sb.ToString()), AspNetPager1);
    }
    protected string Getshenhe(object obj)
    {
        bool boo = Convert.ToBoolean(obj);
        return boo ? "√" : "×";
    }
    protected System.Drawing.Color GetshenheColor(object obj)
    {
        bool boo = Convert.ToBoolean(obj);
        return boo ? System.Drawing.Color.Green : System.Drawing.Color.Red;
    }
    protected void rptNewslist_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "delete")
        {
            int id = Convert.ToInt32(e.CommandArgument);
            bhi.Delete(id);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('删除成功')</script>");
        }
        else if (e.CommandName == "ReSet")
        {
            try
            {
                int id = Convert.ToInt32(e.CommandArgument);
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql("UPDATE hnf_user SET user_password='" +
                                                             Common.Md5("000000") + "' WHERE user_id=" + id);
                Common.MsgBox0("初始化成功！", Page);
            }
            catch (Exception)
            {
                Common.MsgBox0("初始化失败！", Page);
                return;
            }
        }
        else
        {
            try
            {
                string _Value = "0";
                if (e.CommandName.ToString() == "0")
                {
                    _Value = "1";
                }
                Maticsoft.DBUtility.DbHelperSQL.ExecuteSql("UPDATE hnf_user SET user_isable=" + _Value + " WHERE user_id=" + Convert.ToInt32(e.CommandArgument));
            }
            catch (Exception)
            {
                return;
            }
        }
        BindData();
    }
    public string getshow(int state)
    {
        string temp = string.Empty;
        switch (state)
        {
            case 0:
                temp = "首页不显示";
                break;
            case 1:
                temp = "首页显示";
                break;
        }
        return temp;
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        BindData();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("useradd.aspx");
    }
}