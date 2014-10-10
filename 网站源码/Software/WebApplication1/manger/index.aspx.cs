using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manger_index : basepage
{
    protected void Page_Load(object sender, EventArgs e)
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
}