using System;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Net.Mail;
using Wuqi.Webdiyer;
using NewsSolution.BLL;


/// <summary>
/// Common 的摘要说明
/// </summary>
public class Common
{
    public Common()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    /// <summary>
    /// 获取文本编辑器的数据，并获得远程图片名称
    /// </summary>
   public string GetText(string str)
    {
        string mycontext = Regex.Replace(str, @"src[^>]*[^/].(?:jpg|bmp|gif|png|jpeg|JPG|BMP|GIF|JPEG)(?:\""|\')", new MatchEvaluator(SaveYuanFile));
        
        return mycontext;
    }
/// <summary>
/// 
/// </summary>
    private string SaveYuanFile(Match m)
    {
        string imgurl = "";
        string matchstr = m.Value;//str[i].ToString();
        string tempimgurl = "";
        tempimgurl = matchstr.Substring(5);
        tempimgurl = tempimgurl.Substring(0, tempimgurl.IndexOf("\""));

        Regex re = new Regex(@"^http://*");
        if (re.Match(tempimgurl).Success)
        {
            matchstr = matchstr.Substring(5);
            matchstr = matchstr.Substring(0, matchstr.IndexOf("\""));

            //远程文件保存路径
            string Folders = ConfigurationManager.AppSettings["yuanimg"].ToString();
            string fullname = matchstr;

            string huozui = fullname.Substring(fullname.LastIndexOf("."));
            string filename = Common.GetFileName();
            string path = Folders + filename + huozui;
            if (System.IO.File.Exists(System.Web.HttpContext.Current.Request.MapPath(path)))
                System.IO.File.Delete(System.Web.HttpContext.Current.Request.MapPath(path));
                GetHttpFile(matchstr, System.Web.HttpContext.Current.Request.MapPath(path));
                imgurl = "src=\"" + path.Replace("~/", "") + "\"";
        }
        else
        {
            imgurl = matchstr;
        }


        return imgurl;
    }


    string sException = null;
    /// <summary>
    /// 根据给出的HttpFile文件和上传的路径，将文件上传到远程服务器的路径中
    /// </summary>
    private bool GetHttpFile(string sUrl, string sSavePath)
    {
        bool bRslt = false;
        WebResponse oWebRps = null;
        WebRequest oWebRqst = WebRequest.Create(sUrl);
        oWebRqst.Timeout = 100000;
        try
        {
            oWebRps = oWebRqst.GetResponse();
        }
        catch (WebException e)
        {
            sException = e.Message.ToString();
        }
        catch (Exception e)
        {
            sException = e.ToString();
        }
        finally
        {
            if (oWebRps != null)
            {
                BinaryReader oBnyRd = new BinaryReader(oWebRps.GetResponseStream(), System.Text.Encoding.GetEncoding("GB2312"));
                int iLen = Convert.ToInt32(oWebRps.ContentLength);
                FileStream oFileStream;
                try
                {
                    if (File.Exists(System.Web.HttpContext.Current.Request.MapPath("RecievedData.tmp")))
                    {
                        oFileStream = File.OpenWrite(sSavePath);
                    }
                    else
                    {
                        oFileStream = File.Create(sSavePath);
                    }
                    oFileStream.SetLength((Int64)iLen);
                    oFileStream.Write(oBnyRd.ReadBytes(iLen), 0, iLen);
                    oFileStream.Close();
                }
                catch (Exception)
                {
                    //bRslt= false;
                    oBnyRd.Close();
                    oWebRps.Close();
                }
                finally
                {
                    oBnyRd.Close();
                    oWebRps.Close();
                }
                bRslt = true;
            }
        }
        return bRslt;

    }

    /// <summary>
    /// 根据给定的文件实例，完成文件上传
    /// </summary>
      public static string UpLoadFile(FileUpload fileupload, string Folders)
    {
        ;
        string fullname = fileupload.PostedFile.FileName;
        if ((fullname == null) || (fullname.Equals("")))
            return "";
        string huozui = fullname.Substring(fullname.LastIndexOf("."));
        string filename = GetFileName();
        string p1 = Folders + filename + huozui;
        string path = System.Web.HttpContext.Current.Server.MapPath(p1);

        if (System.IO.File.Exists(path))
            System.IO.File.Delete(path);
        fileupload.PostedFile.SaveAs(path);
        return p1;
    }

    /// <summary>
    /// 根据年月日时分秒给文件重命名
    /// </summary>
    /// <returns></returns>
    public static string GetFileName()
    {
        System.Threading.Thread.Sleep(1000);
        string str1 = System.DateTime.Now.Year.ToString() + "-";

        if ((System.DateTime.Now.Month).ToString().Length < 2)
        {
            str1 += "0" + System.DateTime.Now.Month.ToString() + "-";
        }
        else
        {
            str1 += System.DateTime.Now.Month.ToString() + "-";
        }

        if ((System.DateTime.Now.Day).ToString().Length < 2)
        {
            str1 += "0" + System.DateTime.Now.Day.ToString() + "-";
        }
        else
        {
            str1 += System.DateTime.Now.Day.ToString() + "-";
        }

        if ((System.DateTime.Now.Hour).ToString().Length < 2)
        {
            str1 += "0" + System.DateTime.Now.Hour.ToString() + "-";
        }
        else
        {
            str1 += System.DateTime.Now.Hour.ToString() + "-";
        }

        if ((System.DateTime.Now.Minute).ToString().Length < 2)
        {
            str1 += "0" + System.DateTime.Now.Minute.ToString() + "-";
        }
        else
        {
            str1 += System.DateTime.Now.Minute.ToString() + "-";
        }

        if ((System.DateTime.Now.Second).ToString().Length < 2)
        {
            str1 += "0" + System.DateTime.Now.Second.ToString();
        }
        else
        {
            str1 += System.DateTime.Now.Second.ToString();
        }

        return str1;
    }

    #region 发送邮件
   
    /// <summary> 
    /// 发送邮件 
    /// </summary> 
    /// <param name="from">发送人邮件地址</param> 
    /// <param name="to">接收人邮件地址</param> 
    /// <param name="subject">邮件主题</param> 
    /// <param name="isBodyHtml">是否是Html</param> 
    /// <param name="body">邮件体</param> 
    /// <param name="smtpHost">SMTP服务器地址</param> 
    /// <param name="userName">用户名</param> 
    /// <param name="password">密码</param> 
    /// <returns>是否成功</returns> 
    public static bool Send(string from, string to, string subject, bool isBodyHtml, string body, string smtpHost, string userName, string password)
    {
        string[] ts = to.Split(',');
        bool isSuccess = true;
        foreach (string t in ts)
        {
            try
            {
                MailMessage mm = new MailMessage();
                mm.From = new MailAddress(from);

                mm.To.Add(new MailAddress(t.Trim()));

                mm.Subject = subject;
                mm.IsBodyHtml = isBodyHtml;
                mm.Body = body;
                mm.SubjectEncoding = System.Text.Encoding.UTF8;
                mm.BodyEncoding = System.Text.Encoding.UTF8;

                SmtpClient sc = new SmtpClient();
                sc.Host = smtpHost;
                sc.Port =25;
                //sc.UseDefaultCredentials = true;//winform中不受影响，asp.net中，false表示不发送身份严正信息 
                //smtpClient.EnableSsl = true;//如果服务器不支持ssl则报，服务器不支持安全连接 错误 
                sc.Credentials = new System.Net.NetworkCredential(userName, password);
                //sc.DeliveryMethod = SmtpDeliveryMethod.Network;

                sc.Send(mm);
            }
            catch
            {
                isSuccess = false;
            }
        }
        return isSuccess;
    }
    #endregion

    #region 截取字符串

    /// <summary>
    /// substring裁切字符串
    /// </summary>
    /// <param name="content">要截取的字符串</param>
    /// <param name="length">要截取的长度</param>
    /// <param name="StripHTML">是否是html样式</param>
    /// <returns></returns>
    public static  string GetContentSummary(string content, int length, bool StripHTML)
    {
        if (string.IsNullOrEmpty(content) || length == 0)
            return "";
        if (StripHTML)
        {
            System.Text.RegularExpressions.Regex re = new System.Text.RegularExpressions.Regex("<[^>]*>");
            content = re.Replace(content, "");
            content = content.Replace("　", "").Replace(" ", "").Replace("&nbsp;", "");
            if (content.Length <= length)
                return content;
            else
                return content.Substring(0, length) + "...";
        }
        else
        {
            if (content.Length <= length)
                return content;

            int pos = 0, npos = 0, size = 0;
            bool firststop = false, notr = false, noli = false;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            while (true)
            {
                if (pos >= content.Length)
                    break;
                string cur = content.Substring(pos, 1);
                if (cur == "<")
                {
                    string next = content.Substring(pos + 1, 3).ToLower();
                    if (next.IndexOf("p") == 0 && next.IndexOf("pre") != 0)
                    {
                        npos = content.IndexOf(">", pos) + 1;
                    }
                    else if (next.IndexOf("/p") == 0 && next.IndexOf("/pr") != 0)
                    {
                        npos = content.IndexOf(">", pos) + 1;
                        if (size < length)
                            sb.Append("<br />");
                    }
                    else if (next.IndexOf("br") == 0)
                    {
                        npos = content.IndexOf(">", pos) + 1;
                        if (size < length)
                            sb.Append("<br />");
                    }
                    else if (next.IndexOf("img") == 0)
                    {
                        npos = content.IndexOf(">", pos) + 1;
                        if (size < length)
                        {
                            sb.Append(content.Substring(pos, npos - pos));
                            size += npos - pos + 1;
                        }
                    }
                    else if (next.IndexOf("li") == 0 || next.IndexOf("/li") == 0)
                    {
                        npos = content.IndexOf(">", pos) + 1;
                        if (size < length)
                        {
                            sb.Append(content.Substring(pos, npos - pos));
                        }
                        else
                        {
                            if (!noli && next.IndexOf("/li") == 0)
                            {
                                sb.Append(content.Substring(pos, npos - pos));
                                noli = true;
                            }
                        }
                    }
                    else if (next.IndexOf("tr") == 0 || next.IndexOf("/tr") == 0)
                    {
                        npos = content.IndexOf(">", pos) + 1;
                        if (size < length)
                        {
                            sb.Append(content.Substring(pos, npos - pos));
                        }
                        else
                        {
                            if (!notr && next.IndexOf("/tr") == 0)
                            {
                                sb.Append(content.Substring(pos, npos - pos));
                                notr = true;
                            }
                        }
                    }
                    else if (next.IndexOf("td") == 0 || next.IndexOf("/td") == 0)
                    {
                        npos = content.IndexOf(">", pos) + 1;
                        if (size < length)
                        {
                            sb.Append(content.Substring(pos, npos - pos));
                        }
                        else
                        {
                            if (!notr)
                            {
                                sb.Append(content.Substring(pos, npos - pos));
                            }
                        }
                    }
                    else
                    {
                        npos = content.IndexOf(">", pos) + 1;
                        sb.Append(content.Substring(pos, npos - pos));
                    }
                    if (npos <= pos)
                        npos = pos + 1;
                    pos = npos;
                }
                else
                {
                    if (size < length)
                    {
                        sb.Append(cur);
                        size++;
                    }
                    else
                    {
                        if (!firststop)
                        {
                            sb.Append("...");
                            firststop = true;
                        }
                    }
                    pos++;
                }

            }
            return sb.ToString();
        }
    }
    #endregion
    
    #region 验证输入字符
   /// <summary>
   /// 验证输入字符串内容为数字格式
   /// </summary>
   public static bool IsNumberic(string oText)
    {
        try
        {
            int var1 = Convert.ToInt32(oText);
            return true;
        }
        catch
        {
            return false;
        }
    }
    #endregion

    #region  写错误日志
    /// <summary>
    /// 写程序错误日志
    /// </summary>    
    public static void WriteLogTxt(string logcontent,string type)
    {
        string logname = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
        Page p=new Page();
        
        try
        {
            string url = p.Server.MapPath("~/") + "App_Data/logtxts/"+logname;
            StreamWriter sw=new StreamWriter(url,true);
            sw.Write(DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss-fff")+"--错误类型："+type+"--错误："+logcontent+"\n");
            sw.Close();
        }
        catch (Exception)
        {
            throw ;
        }
    }
    #endregion

    #region 
    /// <summary>
    /// 获取文章中第一张图片的地址
    /// </summary>
    /// <param name="html">文章内容</param>
    /// <param name="regstr">取图片的正则表达式</param>
    /// <param name="keyname">要区属性的名称</param>
    public static ArrayList getImgUrl(string html, string regstr, string keyname)
    {
        ArrayList resultStr = new ArrayList();
        Regex r = new Regex(regstr, RegexOptions.IgnoreCase);
        MatchCollection mc = r.Matches(html);

        foreach (Match m in mc)
        {
            resultStr.Add(m.Groups[keyname].Value.ToLower());
        }
        if (resultStr.Count > 0)
        {
            return resultStr;
        }
        else
        {
            //没有地址的时候返回空字符
            resultStr.Add("");
            return resultStr;
        }
    }
  
    /// <summary>
    /// 获取文章第一张图片的地址
    /// </summary>
    public static string GetImgUrl(string html)
    {
        //ArrayList resultStr = new ArrayList();
        string regstr = @"<IMG[^>]+src=\s*(?:’(?<src>[^']+)’|""(?<src>[^""]+)""|(?<src>[^>\s]+))\s*[^>]*>";
        string resulrStr = "";
        Regex r = new Regex(regstr, RegexOptions.IgnoreCase);
        MatchCollection mc = r.Matches(html);
        foreach (Match m in mc)
        {
            resulrStr = m.Groups["src"].Value.ToLower();
        }
        return resulrStr;
    }
    /// <summary>
    /// 获取文章中第一张图片
    /// </summary>
    /// <param name="html">文章内容</param>
    /// <param name="regstr">正则表达式</param>
    /// <param name="keyname">属性名称</param>
    public static string GetImgUrl1(string html, string regstr, string keyname)
    {
        //ArrayList resultStr = new ArrayList();
        string resulrStr = "";
        Regex r = new Regex(regstr, RegexOptions.IgnoreCase);
        MatchCollection mc = r.Matches(html);
        foreach (Match m in mc)
        {
            resulrStr = m.Groups[keyname].Value.ToLower();
        }
        return resulrStr;
    }
    #endregion

    #region 绑定Literal
    /// <summary>
    /// 绑定Literal，将字符串内容绑定到Literal控件上
    /// </summary>  
    public static void BindLiteral(Literal lit,string strs)
    {
        lit.Text = strs;
    }
    #endregion

    #region 绑定Repeater
    /// <summary>
    /// 绑定Repeater
    /// </summary>
    /// <param name="rpt">RepeaterID</param>
    /// <param name="ds">DataSet</param>
    public static void BindRepeater(Repeater rpt,DataSet ds)
    {
        rpt.DataSource = ds;
        rpt.DataBind();
    }
    /// <summary>
    /// 绑定Repeater
    /// </summary>
    /// <param name="rpt">RepeaterID</param>
    public static void BindRepeater(Repeater rpt,string strWhere)
    {
        NewsSolution.BLL.hnf_news bnews = new NewsSolution.BLL.hnf_news();
        rpt.DataSource = bnews.GetList(strWhere);
        rpt.DataBind();
    }
    /// <summary>
    /// 绑定Repeater(前top条新闻)
    /// </summary>
    /// <param name="rpt">Repeater控件id号</param>
    /// <param name="top">top个数</param>
    /// <param name="strWhere">news 条件</param>
    public static void BindRepeater(Repeater rpt,int top, string strWhere)
    {
        NewsSolution.BLL.hnf_news bnews = new NewsSolution.BLL.hnf_news();
        rpt.DataSource = bnews.GetList(top,strWhere);
        rpt.DataBind();
    }

    public static void BindRepeater1(Repeater rpt, int top, string strWhere)
    {
        NewsSolution.BLL.hnf_huandeng bhuan = new NewsSolution.BLL.hnf_huandeng();
        rpt.DataSource = bhuan.GetList(top, strWhere);
        rpt.DataBind();
    }
    #endregion
    /// <summary>
    /// 绑定网站标题Title
    /// </summary>
    public static string GetPageTitle()
    {
        NewsSolution.BLL.hnf_baseinfo bhb = new NewsSolution.BLL.hnf_baseinfo();
        NewsSolution.Model.hnf_baseinfo mhb = bhb.GetModel(1);
        return mhb.base_seotitle;
    }
    /// <summary>
    /// 绑定页面SEO
    /// </summary>
    /// <param name="lit"></param>
    /// <param name="isKeyword"></param>
    public static void GetSeo(Literal lit, bool isKeyword)
    {
        NewsSolution.BLL.hnf_baseinfo bhb = new NewsSolution.BLL.hnf_baseinfo();
        NewsSolution.Model.hnf_baseinfo mhb = bhb.GetModel(1);

        if (isKeyword)
        {
            lit.Text = "<meta name=\"keywords\" content=\"" + mhb.base_keyword + "\" />";
        }
        else
        {
            lit.Text = "<meta name=\"Description\" content=\"" + mhb.base_describ + "\" />";
        }
    }
    /// <summary>
    /// 新闻页的seo
    /// </summary>
    /// <param name="id"></param>
    /// <param name="lit"></param>
    /// <param name="isKeyword"></param>
    public static void BindSeo(int id, Literal lit, bool isKeyword)
    {
        NewsSolution.BLL.hnf_news bn = new NewsSolution.BLL.hnf_news();
        NewsSolution.Model.hnf_news mn = new NewsSolution.Model.hnf_news();
        NewsSolution.BLL.hnf_baseinfo bhb = new NewsSolution.BLL.hnf_baseinfo();
        NewsSolution.Model.hnf_baseinfo mhb = bhb.GetModel(1);
        mn = bn.GetModel(id);
        if (isKeyword)
        {
            if (mn.news_seotitle != "默认设置")
            {
                lit.Text = "<meta name=\"keywords\" content=\"" + mn.news_keyword + "\" />";
            }
            else
            {
                lit.Text = "<meta name=\"keywords\" content=\"" + mhb.base_keyword + "\" />";
            }
        }
        else
        {
            if (mn.news_describ != "默认设置")
            {
                lit.Text = "<meta name=\"Description\" content=\"" + mn.news_describ + "\" />";
            }
            else
            {
                lit.Text = "<meta name=\"Description\" content=\"" + mhb.base_describ + "\" />";
            }
        }
    }
    public static void BindSeo1(int id, Literal lit, bool isKeyword)
    {
        NewsSolution.BLL.hnf_filedown bn = new NewsSolution.BLL.hnf_filedown();
        NewsSolution.Model.hnf_filedown mn = new NewsSolution.Model.hnf_filedown();
        NewsSolution.BLL.hnf_baseinfo bhb = new NewsSolution.BLL.hnf_baseinfo();
        NewsSolution.Model.hnf_baseinfo mhb = bhb.GetModel(1);
        mn = bn.GetModel(id);
        if (isKeyword)
        {
            if (mn.down_keyword != "默认设置")
            {
                lit.Text = "<meta name=\"keywords\" content=\"" + mn.down_keyword + "\" />";
            }
            else
            {
                lit.Text = "<meta name=\"keywords\" content=\"" + mhb.base_keyword + "\" />";
            }
        }
        else
        {
            if (mn.down_describ != "默认设置")
            {
                lit.Text = "<meta name=\"Description\" content=\"" + mn.down_describ + "\" />";
            }
            else
            {
                lit.Text = "<meta name=\"Description\" content=\"" + mhb.base_describ + "\" />";
            }
        }
    }
    //分页banding
    public static void PagerBind(Repeater rpt, DataSet ds, AspNetPager AspNetPager1)
    {
        
            PagedDataSource pds = new PagedDataSource();
            AspNetPager1.RecordCount = ds.Tables[0].Rows.Count;
            pds.DataSource = ds.Tables[0].DefaultView;
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            rpt.DataSource = pds;
            rpt.DataBind();
       
    }

    #region 一个含有“确定”的警告框
    /// <summary>
    /// 一个含有“确定”的警告框
    /// </summary>
    /// <param name="_Msg">警告字串</param>
    /// <param name="URL">“确定”以后要转到预设网址</param>
    public static string MsgBox0(string _Msg, Page _Page)
    {
        string StrScript;
        StrScript = ("<script language=javascript>");
        StrScript += ("alert('" + _Msg + "');");
        //StrScript += ("window.close();");
        StrScript += ("</script>");
        //_Page.RegisterStartupScript("MsgBox0", StrScript.ToString());
        _Page.ClientScript.RegisterClientScriptBlock(_Page.GetType(), "MsgBox0", StrScript.ToString());
        return StrScript;
    }

    #endregion

    #region 一个含有“确定”、“取消”的警告框
    /// <summary>
    /// 一个含有“确定”、“取消”的警告框
    /// </summary>
    /// <param name="_Msg">警告字串</param>
    /// <param name="URL">“确定”以后要转到预设网址</param>
     public static string MsgBox1(string _Msg, string URL, Page _Page)
    {
        string StrScript;
        StrScript = ("<script language=javascript>");
        StrScript += "var retValue=window.confirm('" + _Msg + "');" + "if(retValue){window.location='" + URL + "';}";
        StrScript += ("</script>");
        //_Page.RegisterStartupScript("MsgBox1", StrScript.ToString());
        _Page.ClientScript.RegisterClientScriptBlock(_Page.GetType(), "MsgBox1", StrScript.ToString());
        return StrScript;
    }
    public static string MsgBox1(string _Msg, Page _Page)
    {
        string StrScript;
        StrScript = ("<script language=javascript>");
        StrScript += "var retValue=window.confirm('" + _Msg + "');";
        StrScript += ("</script>");
        //_Page.RegisterStartupScript("MsgBox1", StrScript.ToString());
        _Page.ClientScript.RegisterClientScriptBlock(_Page.GetType(), "MsgBox1", StrScript.ToString());
        return StrScript;
    }
    #endregion

    #region 一个含有“确定”，点击以后就转到预设网址的警告框
    /// <summary>
    /// 一个含有“确定”，点击以后就转到预设网址的警告框
    /// </summary>
    /// <param name="_Msg">警告字串</param>
    /// <param name="URL">“确定”以后要转到预设网址</param>
       public static string MsgBox2(string _Msg, string URL, Page _Page)
    {
        string StrScript;
        StrScript = ("<script language=javascript>");
        StrScript += ("alert('" + _Msg + "');");
        StrScript += ("window.location='" + URL + "';");
        StrScript += ("</script>");
        //_Page.RegisterStartupScript("MsgBox2", StrScript.ToString());
        _Page.ClientScript.RegisterClientScriptBlock(_Page.GetType(), "MsgBox2", StrScript.ToString());
        return StrScript;
    }
    #endregion

    #region 一个含有“确定”，点击关闭本页的警告框
    /// <summary>
    /// 一个含有“确定”，点击关闭本页的警告框
    /// </summary>
    public static string MsgBox3(string _Msg, Page _Page)
    {
        string StrScript;
        StrScript = ("<script language=javascript>");
        StrScript += ("alert('" + _Msg + "');");
        StrScript += ("window.close();");
        StrScript += ("</script>");
        _Page.ClientScript.RegisterClientScriptBlock(_Page.GetType(), "MsgBox3", StrScript.ToString());
        return StrScript;
    }
    #endregion

   public static string Md5(string pwd)
   {
         return  System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "md5"); 
   }

   /// <summary>
   /// 检测是否为字母数字和下划线
   /// </summary>
   /// <param name="strEmail"></param>
   /// <returns></returns>
   public static bool IsValidName(string strEmail)
   {
       return Regex.IsMatch(strEmail, @"^\w+$");
   }
    
   public static object GetContentSummary(object p, int p_2, bool p_3)
   {
       throw new NotImplementedException();
   }
}
