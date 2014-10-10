using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NewsSolution.BLL;

public partial class countlist : basepage
{
    NewsSolution.BLL.hnf_news bhn = new NewsSolution.BLL.hnf_news();
    NewsSolution.BLL.hnf_imagefile img = new NewsSolution.BLL.hnf_imagefile();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            int year = Convert.ToInt32(DateTime.Now.Year.ToString());
            int month = Convert.ToInt32(DateTime.Now.Month.ToString());
            txtnew.Text = bhn.getnum(16, year, month).ToString();
            txtdy.Text = bhn.getnum(18, year, month).ToString();
            txtfc.Text = img.getnum(2, year, month).ToString();
            txtfx.Text = img.getnum(5, year, month).ToString();
            txtit.Text = bhn.getnum(17, year, month).ToString();
            txtjy.Text = bhn.getnum(19, year, month).ToString();
            txtzj.Text = bhn.getnum(20, year, month).ToString();
            txtxgxj.Text = img.getnum(4, year, month).ToString();

            basepage bp = new basepage();
            string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "统计成功！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
            Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);

            Common.MsgBox0("操作成功！", Page);
        }
        catch (Exception)
        {
            Common.MsgBox0("操作失败！", Page);
            basepage bp = new basepage();
            string sql = "insert into hnf_loginlog (log_type,log_note,log_ip,log_time) values(1,'【管理员" + Session["Mname"] + "统计失败！】','" + bp.GetIp() + "','" + DateTime.Now + "')";
            Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(sql);
            return;
        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        txtnew.Text = "0";
        txtdy.Text = "0";
        txtfc.Text = "0";
        txtfx.Text = "0";
        txtit.Text = "0";
        txtjy.Text = "0";
        txtzj.Text = "0";
        txtxgxj.Text = "0";
    }
}