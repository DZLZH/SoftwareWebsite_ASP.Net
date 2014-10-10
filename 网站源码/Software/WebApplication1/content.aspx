<%@ Page Language="C#" AutoEventWireup="true" CodeFile="content.aspx.cs" Inherits="content" %>
<%@ Register Src="~/usercontrol/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/foot.ascx"  TagName="foot" TagPrefix="uc2" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>软件特色专业</title>
 <link href="~/Styles/Styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
      <div class="Page">
      <uc1:Menu ID="Menu" runat="server" />
        <div class="Content">
         <asp:Image ID="img" runat="server"  />
              <div class="title_about">
                  <strong>当前位置</strong>：<a href="index.aspx">首页</a>  >><%=typename %>
              </div>
              <div class="nr_r_d">
                <div class="title_e">
                    <h3> <asp:Literal ID="litNewsTitle" runat="server"></asp:Literal></h3>
                    <p>
                       发布时间：<asp:Literal ID="litNewsTime" runat="server"></asp:Literal> 
                       点击数量：<asp:Literal ID="litNewsClicks" runat="server"></asp:Literal>
                    </p>
                </div>
                <div class="nr_r_c">
                    <div style=" height:450px; width:90%; overflow:auto;text-align:left;">
                    <asp:Literal ID="litNewsContent" runat="server"></asp:Literal>
                    </div>
                </div>

            </div>
        </div>
      <uc2:foot ID="foot" runat="server" />
      </div>
    </form>
</body>
</html>
