<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>
<%@ Register Src="~/usercontrol/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/foot.ascx"  TagName="foot" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>软件特色专业</title>
    <link href="~/Styles/Styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="Page">
      <uc1:Menu id="Menu" runat="server" />
      <div class="Content">
         <img src="image/content.jpg"  usemap="#Map"  alt=""/>
          <map name="Map" id="Map">
            <area shape="rect" coords="217, 5, 287, 100" href="bys.aspx" />
            <area shape="rect" coords="374, 75, 461, 171" href="xxlj.aspx" />
            <area shape="rect" coords="370, 288, 467, 380" href="ekzgzs.aspx" />
            <area alt="" shape="rect" coords="215, 395, 286, 491" href="monimianshi.aspx" />
            <area shape="rect" coords="9, 292, 178, 382" href="sztz.aspx" />
            <area shape="rect" coords="50, 78, 131, 173" href="sx.aspx" />
          </map>
          <div>
          <div class="xw">
              <div class="title">
                  <p>新闻中心</p><span><a href="list.aspx?tid=1"><<更多</a></span>
              </div>
              <ul class="all_a">
              <asp:Repeater ID="rptXinwen" runat="server">
              <ItemTemplate>
              <li>
              <a style="width:140px" href='content.aspx?nid=<%#Eval("news_id") %>' target="_blank" title=''><%#Common.GetContentSummary(Eval("news_name").ToString(),10,false) %></a>
              <span><%#Eval("news_alertime","{0:yy-MM-dd}") %></span>
              </li>
              </ItemTemplate>
              </asp:Repeater>
              </ul>
          </div>
         <div class="xw">
              <div class="title">
                  <p>行业动态</p><span><a href="list.aspx?tid=10"><<更多</a></span>
              </div>
              <ul class="all_a">
              <asp:Repeater ID="Repeater1" runat="server">
              <ItemTemplate>
              <li>
              <a style="width:140px" href='content.aspx?nid=<%#Eval("news_id") %>' target="_blank" title=''><%#Common.GetContentSummary(Eval("news_name").ToString(),10,false) %></a>
              <span><%#Eval("news_alertime","{0:yy-MM-dd}") %></span>
              </li>
              </ItemTemplate>
              </asp:Repeater>
              </ul>
          </div>
        </div>
      </div>
      <uc2:foot id="foot" runat="server"/>
    </div>
    </form>
</body>
</html>
