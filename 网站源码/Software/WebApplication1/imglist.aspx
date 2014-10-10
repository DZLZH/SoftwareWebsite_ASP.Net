<%@ Page Language="C#" AutoEventWireup="true" CodeFile="imglist.aspx.cs" Inherits="imglist" %>
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
          <img src="image/5.png" />
            
              <div class="title_about">
                  <strong>当前位置</strong>：<a href="index.aspx">首页</a>  >><%=typename %>
              </div>
            <div class="pingyi_list">
            <ul>
            <asp:Repeater ID="rptImageList" runat="server" >
                        <ItemTemplate>
                            <li>
                               <a href='content.aspx?nid=<%#Eval("news_id") %>' title='<%#Eval("news_name") %>'> <img src='Files/<%#Eval("news_image") %>' width="150" height="110"  alt='<%#Eval("news_name") %>'/></a>
                                <p><a href='content.aspx?nid=<%#Eval("news_id") %>' title='<%#Eval("news_name") %>'><%#Common.GetContentSummary(Eval("news_name").ToString(),10,false) %></a></p>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
            </ul>
           </div>
            <div class="fenye">
            <webdiyer:AspNetPager ID="AspNetPager1" runat="server"  AlwaysShow="false"
                onpagechanged="AspNetPager1_PageChanged" PageSize="12" Width="90%" 
                        ShowPageIndexBox="Always" SubmitButtonText="Go" 
                        TextAfterPageIndexBox="页" TextBeforePageIndexBox="转到">
            </webdiyer:AspNetPager>
            </div>
         </div>
      <uc2:foot ID="foot" runat="server" />
      </div>
    </form>
</body>
</html>
