<%@ Page Language="C#" AutoEventWireup="true" CodeFile="xxlj.aspx.cs" Inherits="xxlj" %>
<%@ Register Src="~/usercontrol/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/foot.ascx"  TagName="foot" TagPrefix="uc2" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>软件特色专业</title>
    <link href="~/Styles/Styles.css" rel="stylesheet" type="text/css" />
   
    <style type="text/css">
        .table img {
           width:150px; height:50px;
        }
        .table {
         width:80%;  text-align:left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="Page">
      <uc1:Menu id="Menu" runat="server" />
      <div class="Content">
          <img src="image/技.png"    alt=""/>
          <p style=" font-size:18px; font-weight:bold; text-align:left; padding:10px 50px; "> </p>
          <div class="table">
              <table>
                  <tr>
                      <td rowspan="2"  width="200"><img  alt="" src="image/u1.jpg" /></td>
                      <td>网站名称：素材中国</td>
                  </tr>
                  <tr>
                      
                      <td><a href="http://www.sccnn.com/">http://www.sccnn.com/</a></td>
                  </tr>
                  <tr><td colspan="2" > &nbsp;&nbsp;  素材中国 专注于提供平面广告设计素材下载，其内容涵盖了psd素材，矢量素材，PPT模板，网站源码，网页素材，flash素材，png图标，ps笔刷等，让任何一个设计师都能轻松找到自己想要的素材！
素材中国</td></tr>
              </table>

              <table>
                  <tr>
                      <td rowspan="2" width="200"><img alt="" src="image/u3.jpg" /></td>
                      <td>网站名称：CSDN</td>
                  </tr>
                  <tr>
                      <td><a href="http://www.csdn.net/">http://www.csdn.net/</a></td>
                  </tr>
                  <tr><td colspan="2" > &nbsp;&nbsp; CSDN是中国软件开发联盟（Chinese software develop net）的缩写，是中国最大的开发者技术社区。它是集新闻、论坛、群组、Blog、文档、下载、读书、Tag、网摘、搜索、.NET、Java、游戏、视频、人才、外包、第二书店、《程序员》等多种项目于一体的大型综合性IT门户网站，有很强的专业性，其会员囊括了中国地区百分之九十以上的优秀程序员，在IT技术交流及其周边国内中是第一位的网站。</td></tr>
              </table>
              <table>
                  <tr>
                      <td rowspan="2" width="200"><img alt="" src="image/u5.jpg" /></td>
                      <td>网站名称：IT部落</td>
                  </tr>

                  <tr>
                      <td><a href="http://www.itbulo.com/">http://www.itbulo.com/</a></td>
                  </tr>
                  <tr><td colspan="2" > &nbsp;&nbsp;IT部落网站创立于2005年5月（前身为创立于2002年的潇潇雨吧），经过几年时间的发展，现已成为最大的中文IT软件站点。日访问量突破几十万IP，日页面访问量突破几百万次，并保持稳定增长的趋势。旗下包含：软件资讯，软件学院，IT人，软件下载，源码下载，字体下载，图片素材库，壁纸频道 等几大主力站点。</td></tr>
              </table>
              <table>
                  <tr>
                      <td rowspan="2" width="200"><img alt="" src="image/u6.jpg" /></td>
                      <td>网站名称：第一源码网

                      </td>
                  </tr>
                  <tr>
                      <td><a href="http://www.codefans.com/">http://www.codefans.com/</a></td>
                  </tr>
                  <tr><td colspan="2" > &nbsp;&nbsp; 第一源码网，创建于2012年9月，是一个专门为广大站长和源码爱好者提供各种建站源码的网站。第一源码网域名中所有源码都经过我们精心测试通过，不但提供ASP源码、PHP源码、.NET源码、FLASH源码、C++等源码，还同时提供各种站长工具教程。另外本网还同时提供了韩国模板、欧美模板、日本模板等各种网页模板和建站素材下载。第一源码网是一个以编程源代码下载见长的专业性站长资源网站！</td></tr>
              </table>
          </div>
          <div style="float:left; text-align:center; width:100%; margin-top:10px;"><p><a href="xxlj.aspx"><<</a>&nbsp;<a href="xxlj.aspx"><</a>&nbsp;1&nbsp;<a href="xxlj.aspx">2</a>&nbsp;<a href="xxlj.aspx">></a>&nbsp; <a href="xxlj.aspx">>></a>  转到<asp:TextBox ID="TextBox1" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Width="22px">2</asp:TextBox>页<asp:Button ID="Button1" runat="server" Text="GO" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" /></p></div>
       </div>
      <uc2:foot id="foot" runat="server"/>
    </div>
    </form>
</body>
</html>