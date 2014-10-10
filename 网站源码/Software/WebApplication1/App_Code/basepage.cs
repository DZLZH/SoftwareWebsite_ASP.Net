using System;
using System.Collections;
using System.Data;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI;
using System.Web;

/// <summary>
///basepage 的摘要说明
/// </summary>
public class basepage : System.Web.UI.Page
{
    public basepage()
    {
        
        //TODO: 在此处添加构造函数逻辑
        
        Load += new EventHandler(this.log_user);
        Page.Error += error;
    }

    /// <summary>
    /// 获取页面当中出错的地方
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="e"></param>
    void error(object obj, EventArgs e)
    {
        //writeLog(Server.GetLastError().Message);
        //页面是否显示错误
        //throw Server.GetLastError();
        //跳转到错误页面
        //Common.WriteLogTxt(Server.GetLastError().Message, "后天错误日志");
        Response.Redirect(Request.ApplicationPath + "/Error.htm");
    }

    public void log_user(object sender, System.EventArgs e)
    {
        try
        {
            if (Session["flag"].ToString() == "" || Session["flag"] == null)
            {
                Response.Redirect("~/manger/login.aspx");
            }

        }
        catch (Exception)
        {
            Response.Redirect("~/manger/login.aspx");
        }
    }

    //protected override void Render(HtmlTextWriter writer)
    //{
    //    StringWriter sw = new StringWriter();
    //    base.Render(new HtmlTextWriter(sw));//获取正常输出的html，包含__VIEWSTATE

    //    string html = sw.ToString();

    //    html = Regex.Replace(html, @"<div[\s\S]*?__VIEWSTATE[\s\S]*?</div>", "");//过滤__VIEWSTATE
    //    writer.WriteLine(html.Trim());//输出过滤后的html

    //}
    public string GetIp()
    {
        if (HttpContext.Current.Request.ServerVariables["HTTP_VIA"] != null)
        {
            return HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        }
        return HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
    }

    #region //public树形分类

    public void getTreeList(DropDownList ddList, DataTable tbList, string type_id, string type_depth, string type_name)
    {
        foreach (DataRow dr in tbList.Rows)
        {
            int depth = Convert.ToInt32(dr[type_depth]);
            string name = dr[type_name].ToString();
            string space = "";
            if (depth > 1)
            {
                space = new string('　', depth - 1);
            }
            if (depth > 0)
            {
                name = space + "├" + name;
            }
            ListItem item = new ListItem(name, dr[type_id].ToString());
            ddList.Items.Add(item);
        }
    }

    public void getTreeList(DropDownList ddList, DataTable tbList, int SelID, string type_id, string type_depth, string type_name)
    {
        foreach (DataRow dr in tbList.Rows)
        {
            int depth = Convert.ToInt32(dr[type_depth]);
            string name = dr[type_name].ToString();
            string space = "";
            if (depth > 1)
            {
                space = new string('　', depth - 1);
            }
            if (depth > 0)
            {
                name = space + "├" + name;
            }
            ListItem item = new ListItem(name, dr[type_id].ToString());
            if (item.Value == SelID.ToString())
            {
                item.Selected = true;
            }
            ddList.Items.Add(item);
        }
    }

    public void getTreeList(DropDownList ddList, DataTable tbList, int SelID, string strExclude, string type_id, string type_name, string type_depth)
    {
        foreach (DataRow dr in tbList.Rows)
        {
            if (dr["SortStr"].ToString().IndexOf(strExclude) != -1) continue;
            int depth = Convert.ToInt32(dr[type_depth]);
            string name = dr[type_name].ToString();
            string space = "";
            if (depth > 1)
            {
                space = new string('　', depth - 1);
            }
            if (depth > 0)
            {
                name = space + "├" + name;
            }
            ListItem item = new ListItem(name, dr[type_id].ToString());
            if (item.Value == SelID.ToString())
            {
                item.Selected = true;
            }
            ddList.Items.Add(item);
        }
    }

    #endregion


    #region //分类树形
    public void getTreeList(DropDownList ddList, DataTable tbList)
    {
        foreach (DataRow dr in tbList.Rows)
        {
            int depth = Convert.ToInt32(dr["n_type_depth"]);
            string name = dr["n_type_name"].ToString();
            string space = "";
            if (depth > 1)
            {
                space = new string('　', depth - 1);
            }
            if (depth > 0)
            {
                name = space + "├" + name;
            }
            ListItem item = new ListItem(name, dr["n_type_id"].ToString());
            ddList.Items.Add(item);
        }
    }


    public void getTreeList(DropDownList ddList, DataTable tbList, int SelID)
    {
        foreach (DataRow dr in tbList.Rows)
        {
            int depth = Convert.ToInt32(dr["n_type_depth"]);
            string name = dr["n_type_name"].ToString();
            string space = "";
            if (depth > 1)
            {
                space = new string('　', depth - 1);
            }
            if (depth > 0)
            {
                name = space + "├" + name;
            }
            ListItem item = new ListItem(name, dr["n_type_id"].ToString());
            if (item.Value == SelID.ToString())
            {
                item.Selected = true;
            }
            ddList.Items.Add(item);
        }
    }

    public void getTreeList(DropDownList ddList, DataTable tbList, int SelID, string strExclude)
    {
        foreach (DataRow dr in tbList.Rows)
        {
            if (dr["SortStr"].ToString().IndexOf(strExclude) != -1) continue;
            int depth = Convert.ToInt32(dr["n_type_depth"]);
            string name = dr["n_type_name"].ToString();
            string space = "";
            if (depth > 1)
            {
                space = new string('　', depth - 1);
            }
            if (depth > 0)
            {
                name = space + "├" + name;
            }
            ListItem item = new ListItem(name, dr["n_type_id"].ToString());
            if (item.Value == SelID.ToString())
            {
                item.Selected = true;
            }
            ddList.Items.Add(item);
        }
    }
    #endregion

    #region //分类树形
    //public void getTreeListp(DropDownList ddList, DataTable tbList)
    //{
    //    foreach (DataRow dr in tbList.Rows)
    //    {
    //        int depth = Convert.ToInt32(dr["p_type_depth"]);
    //        string name = dr["p_type_name"].ToString();
    //        string space = "";
    //        if (depth > 1)
    //        {
    //            space = new string('　', depth - 1);
    //        }
    //        if (depth > 0)
    //        {
    //            name = space + "├" + name;
    //        }
    //        ListItem item = new ListItem(name, dr["p_type_id"].ToString());
    //        ddList.Items.Add(item);
    //    }
    //}

    //public void getTreeListp(DropDownList ddList, DataTable tbList, int SelID)
    //{
    //    foreach (DataRow dr in tbList.Rows)
    //    {
    //        int depth = Convert.ToInt32(dr["p_type_depth"]);
    //        string name = dr["p_type_name"].ToString();
    //        string space = "";
    //        if (depth > 1)
    //        {
    //            space = new string('　', depth - 1);
    //        }
    //        if (depth > 0)
    //        {
    //            name = space + "├" + name;
    //        }
    //        ListItem item = new ListItem(name, dr["p_type_id"].ToString());
    //        if (item.Value == SelID.ToString())
    //        {
    //            item.Selected = true;
    //        }
    //        ddList.Items.Add(item);
    //    }
    //}

    //public void getTreeListp(DropDownList ddList, DataTable tbList, int SelID, string strExclude)
    //{
    //    foreach (DataRow dr in tbList.Rows)
    //    {
    //        if (dr["SortStr"].ToString().IndexOf(strExclude) != -1) continue;
    //        int depth = Convert.ToInt32(dr["p_type_depth"]);
    //        string name = dr["p_type_name"].ToString();
    //        string space = "";
    //        if (depth > 1)
    //        {
    //            space = new string('　', depth - 1);
    //        }
    //        if (depth > 0)
    //        {
    //            name = space + "├" + name;
    //        }
    //        ListItem item = new ListItem(name, dr["p_type_id"].ToString());
    //        if (item.Value == SelID.ToString())
    //        {
    //            item.Selected = true;
    //        }
    //        ddList.Items.Add(item);
    //    }
    //}
    #endregion
}
