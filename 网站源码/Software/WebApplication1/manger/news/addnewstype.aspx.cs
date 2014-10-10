using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using NewsSolution.BLL;
using NewsSolution.Model;
using NewsSolution.DAL;

public partial class manger_news_addnewstype : basepage
{
    NewsSolution.BLL.hnf_n_type bntype = new NewsSolution.BLL.hnf_n_type();
    NewsSolution.Model.hnf_n_type mntype = new NewsSolution.Model.hnf_n_type();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Response.Redirect("~/manger/login.aspx");
        }
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
            getParentList();
            binddate();
        }
    }
    protected void binddate()
    {
        if (hidetypeid.Value != "0")
        {
            DataSet ds = new DataSet();
            ds = bntype.GetList("n_type_id=" + hidetypeid.Value);
            if (ds.Tables.Count > 0)
            {
                txttypename.Text = ds.Tables[0].Rows[0]["n_type_name"].ToString();
                ddlparent.SelectedValue = ds.Tables[0].Rows[0]["n_type_parentid"].ToString();
                if (ds.Tables[0].Rows[0]["n_type_isshow"].ToString() == "0")
                {
                    chkhot.Checked = false;
                }
                else
                {
                    chkhot.Checked = true;
                }
                lbldepth.Text = ds.Tables[0].Rows[0]["n_type_depth"].ToString();
                lblrootid.Text = ds.Tables[0].Rows[0]["n_type_root"].ToString();
                txtsort.Text = ds.Tables[0].Rows[0]["n_type_sort"].ToString();
            }
        }
    }
    private void getParentList()
    {
        DataTable tab = bntype.GetList("1=1 order by n_type_root,n_type_strsort").Tables[0];
        ddlparent.Items.Clear();
        ddlparent.Items.Add("作为顶级分类");
        ddlparent.Items[0].Value = "0";
        this.getTreeList(ddlparent, tab);
    }

    private void getParentList(string strSort, int PID)
    {
        DataTable tab = bntype.GetList("1=1 order by n_type_root,n_type_strsort").Tables[0];
        ddlparent.Items.Clear();
        ddlparent.Items.Add("作为顶级分类");
        ddlparent.Items[0].Value = "0";
        this.getTreeList(ddlparent, tab, PID, strSort);
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (hidetypeid.Value == "0")
        {
            if (ddlparent.SelectedValue == "0")
            {
                mntype.n_type_name = txttypename.Text.Trim();
                mntype.n_type_parentid = 0;
                mntype.n_type_sort = Convert.ToInt32(txtsort.Text.Trim());
                if (chkhot.Checked == true)
                {
                    mntype.n_type_isshow = 1;
                }
                else
                {
                    mntype.n_type_isshow = 0;
                }
                mntype.n_type_strsort = "0";
                int n = Convert.ToInt32(bntype.Add(mntype));
                if (n > 0)
                {
                    DataSet ds1 = new DataSet();
                    ds1 = bntype.GetList("1=1 order by n_type_id desc");
                    mntype.n_type_depth = 0;
                    mntype.n_type_id = Convert.ToInt32(ds1.Tables[0].Rows[0]["n_type_id"]);
                    mntype.n_type_root = Convert.ToInt32(ds1.Tables[0].Rows[0]["n_type_id"]);
                    mntype.n_type_strsort = Convert.ToString(ds1.Tables[0].Rows[0]["n_type_id"]);
                    if (Convert.ToInt32(bntype.Update(mntype)) > 0)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('操作成功');location.href('newstype.aspx');", true);
                        getParentList();
                        binddate();
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('操作失败')", true);
                        return;
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('操作失败')", true);
                    return;
                }

            }
            else
            {
                if (!bntype.addfristtype(Convert.ToInt32(this.ddlparent.SelectedValue)))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('只能添加一级类')", true);
                    return;
                }
                mntype.n_type_name = txttypename.Text.Trim();
                mntype.n_type_parentid = Convert.ToInt32(ddlparent.SelectedValue);
                mntype.n_type_sort = Convert.ToInt32(txtsort.Text.Trim());
                if (chkhot.Checked == true)
                {
                    mntype.n_type_isshow = 1;
                }
                else
                {
                    mntype.n_type_isshow = 0;
                }

                DataSet ds2 = new DataSet();
                ds2 = bntype.GetList("n_type_id=" + ddlparent.SelectedValue);
                mntype.n_type_depth = Convert.ToInt32(ds2.Tables[0].Rows[0]["n_type_depth"]) + 1;
                mntype.n_type_root = Convert.ToInt32(ds2.Tables[0].Rows[0]["n_type_root"]);
                mntype.n_type_strsort = ds2.Tables[0].Rows[0]["n_type_strsort"].ToString() + "," + ds2.Tables[0].Rows[0]["n_type_id"].ToString();
                if (Convert.ToInt32(bntype.Add(mntype)) > 0)
                {
                    DataSet ds3 = new DataSet();
                    ds3 = bntype.GetList("1=1 order by n_type_id desc");
                    mntype.n_type_id = Convert.ToInt32(ds3.Tables[0].Rows[0]["n_type_id"]);
                    mntype.n_type_strsort = ds3.Tables[0].Rows[0]["n_type_strsort"] + "," + ds3.Tables[0].Rows[0]["n_type_id"].ToString();
                    if (Convert.ToInt32(bntype.Update(mntype)) > 0)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('操作成功');location.href('newstype.aspx');", true);
                        getParentList();
                        binddate();
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('操作失败')", true);
                        return;
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('操作失败')", true);
                    return;
                }
            }
        }
        else
        {
            if (ddlparent.SelectedValue == "0")
            {
                mntype = bntype.GetModel(Convert.ToInt32(hidetypeid.Value));
            }
            else
            {
                if (!bntype.addfristtype(Convert.ToInt32(this.ddlparent.SelectedValue)))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('只能添加一级类')", true);
                    return;
                }
                mntype = bntype.GetModel(Convert.ToInt32(ddlparent.SelectedValue));
            }
            mntype.n_type_name = txttypename.Text.Trim();
            mntype.n_type_parentid = Convert.ToInt32(ddlparent.SelectedValue);
            mntype.n_type_sort = Convert.ToInt32(txtsort.Text.Trim());
            if (chkhot.Checked == true)
            {
                mntype.n_type_isshow = 1;
            }
            else
            {
                mntype.n_type_isshow = 0;
            }
            mntype.n_type_strsort = mntype.n_type_strsort.ToString() + "," + hidetypeid.Value.ToString();

            if (ddlparent.SelectedValue != "0")
            {
                mntype.n_type_depth = mntype.n_type_depth + 1;
            }
            else
            {
                mntype.n_type_root = Convert.ToInt32(this.lblrootid.Text.ToString());
            }
            if (this.hidetypeid.Value == this.ddlparent.SelectedValue.ToString())
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('编辑状态不能把自已或子类选为父类')", true);
            }
            else if (this.lblrootid.Text == mntype.n_type_root.ToString() && Convert.ToInt32(this.lbldepth.Text.ToString()) < Convert.ToInt32(mntype.n_type_depth.ToString()))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('编辑状态不能把自已或子类选为父类')", true);
            }
            else
            {
                mntype.n_type_id = Convert.ToInt32(hidetypeid.Value);
                if (Convert.ToInt32(bntype.Update(mntype)) > 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('操作成功');location.href('newstype.aspx');", true);
                    getParentList();
                    binddate();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('操作失败')", true);
                    return;
                }
            }

        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/manger/news/newstype.aspx");
    }
}