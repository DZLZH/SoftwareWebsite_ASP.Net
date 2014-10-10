using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;


/// <summary>
///kefu 的摘要说明
/// </summary>
public class kefu
{
    public bool kefuqq(string strid)
    {
        bool zt = false;
        string url = string.Format("http://wpa.qq.com/pa?p=1:"+strid+":4");
　　　　HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.Headers.Set("Pragma", "no-cache");
　　　　HttpWebResponse HttpWResp = (HttpWebResponse)request.GetResponse();
　　　　string query = HttpWResp.ResponseUri.AbsolutePath;
    switch (query)
    {
        case "/qconn/wpa/button/button_old_41.gif":
            zt=true;break;
        case "/qconn/wpa/button/button_old_40.gif":
            zt = false;break;
    }
    return zt;
    
        //bool zt = false;
        //    string strSearchQQ = "http://wpa.qq.com/pa?p=1:" + strid + ":3";
        //    string strQQStatus = GetWebContent(strSearchQQ).Substring(0, 7);
        //    switch (strQQStatus)
        //    {
        //        case "GIF89aK": zt = true; break;
        //        case "GIF89aJ": zt = false; break;
        //    }
        //    return zt;
      }
    //private string GetWebContent(string Url)
    //{
    //    string strResult = "";
 
    //        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
    //        //声明一个HttpWebRequest请求
    //        request.Timeout = 30000;
    //        //设置连接超时时间
    //        request.Headers.Set("Pragma", "no-cache");
    //        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
    //        Stream streamReceive = response.GetResponseStream();
    //        Encoding encoding = Encoding.GetEncoding("GB2312");
    //        StreamReader streamReader = new StreamReader(streamReceive, encoding);
    //        strResult = streamReader.ReadToEnd();
      
    //    return strResult;
    //}

}