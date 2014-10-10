<%@ Page Language="C#" AutoEventWireup="true" CodeFile="list.aspx.cs" Inherits="list" %>
<%@ Register Src="~/usercontrol/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/foot.ascx"  TagName="foot" TagPrefix="uc2" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>软件特色专业</title>
 <link href="~/Styles/Styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
      <div class="Page">
      <uc1:Menu ID="Menu" runat="server" />
        <div class="Content">
          <asp:Image ID="img" runat="server" />
            
              <div class="title_about">
                  <strong>当前位置</strong>：<a href="index.aspx">首页</a>  >><%=typename %>
              </div>
              <ul class="all_d">
              <asp:Repeater ID="rptNewsList" runat="server">
                <ItemTemplate>
                  <li style=" font-size:14px;border-bottom:1px dashed #ccc;"><span><%#Eval("news_alertime", "{0:yyyy-MM-dd}")%></span><a href='content.aspx?nid=<%#Eval("news_id") %>' title='<%#Eval("news_name") %>'><%#Common.GetContentSummary(Eval("news_name").ToString(),30,false) %></a></li>
                </ItemTemplate>
               </asp:Repeater>
               </ul>
            <div class="fenye">
 <webdiyer:aspnetpager ID="AspNetPager1" runat="server"  AlwaysShow="false"
                onpagechanged="AspNetPager1_PageChanged" PageSize="12" Width="90%" 
                        ShowPageIndexBox="Always" SubmitButtonText="Go" 
                        TextAfterPageIndexBox="页" TextBeforePageIndexBox="转到">
            </webdiyer:aspnetpager>
</div>



        </div>
      <uc2:foot ID="foot" runat="server" />
      </div>
    </form>
</body>
</html>
