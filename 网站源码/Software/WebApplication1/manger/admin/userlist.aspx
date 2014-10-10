<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userlist.aspx.cs" Inherits="manger_admin_userlist" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>软件特色专业</title>
    <link href="../images/skin.css" rel="stylesheet" type="text/css" />
    <script src="../../js/Calendar.js" type="text/javascript"></script>
    <style type="text/css">
        .style1
        {
            height: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="17" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">用户管理</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td valign="top">
<table width="100%" align="center" border="1" cellpadding="0" cellspacing="0" bordercolorlight="#999999" bordercolordark="#FFFFFF" class="newtable">
      <tr>
      <td colspan="6" height="5px" style="background:#bfd3e6; text-align:left">
      &nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chkshow" runat="server" Text="是否可用" /> &nbsp;
            &nbsp;&nbsp;<asp:Button 
                ID="btnQuery" runat="server" Text="搜索" Height="25px" 
                onclick="btnQuery_Click" /> &nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" 
              runat="server" Text="添加新用户" onclick="Button1_Click" />
      </td>
      </tr>
	  <tr style=" font-size:14px;" id="titleone">
		<td width="20%" align="center" bgcolor="#e1e5ee">学号</td>
		<td width="30%" align="center" bgcolor="#e1e5ee">姓名</td>
		<td width="20%" align="center" bgcolor="#e1e5ee">邮箱</td>
		<td width="10%" align="center" bgcolor="#e1e5ee">是否可用</td>
		<td width="10%" align="center" bgcolor="#e1e5ee">密码初始化</td>
		<td width="10%" align="center" bgcolor="#e1e5ee">操作</td>
	  </tr>
	  <asp:Repeater ID="rptNewslist" runat="server" 
          onitemcommand="rptNewslist_ItemCommand">
      <ItemTemplate>
	  <tr onmouseover="this.style.backgroundColor='#e1e5ee';" onmouseout="this.style.backgroundColor='';">
		<td align="left">&nbsp;<%# Eval("user_name")%></td>
		<td align="left">&nbsp;<%#Eval("user_truename")%></td>
		<td align="center">&nbsp;<%#Eval("user_email")%></td>
		<td align="center">&nbsp;<asp:LinkButton ID="lbtshenhe" Text='<%#Getshenhe(Eval("user_isable"))%>' ForeColor='<%#GetshenheColor(Eval("user_isable"))%>' runat="server" CommandName='<%#Eval("user_isable") %>' CommandArgument='<%#Eval("user_id") %>'></asp:LinkButton></td>
		<td align="center">&nbsp;<asp:LinkButton ID="lbtRest" Text=' 重 置 '  runat="server" CommandName='ReSet' CommandArgument='<%#Eval("user_id") %>' OnClientClick="return confirm('确认初始化吗?')"></asp:LinkButton></td>
		<td align="center">
		<a href="useradd.aspx?id=<%#Eval("user_id") %>">修改</a> | <asp:LinkButton ID="LinkButton1" runat="server" CommandName="delete" CommandArgument='<%#Eval("user_id") %>' OnClientClick="return confirm('确认删除吗?')">删除</asp:LinkButton>
		</td>
	  </tr>
	  </ItemTemplate>
      </asp:Repeater>
       <asp:HiddenField ID="hpid" runat="server" />
      <tr>
		<td colspan="6" align="center">
            <webdiyer:AspNetPager ID="AspNetPager1" runat="server" 
                onpagechanged="AspNetPager1_PageChanged" PageSize="15" Width="90%">
            </webdiyer:AspNetPager>
            &nbsp;
        </td>
	  </tr>
</table>
        
        </td>
      </tr>
    </table></td>
    <td background="../images/mail_rightbg.gif">&nbsp;</td>
  </tr>
  <tr>
    <td valign="bottom" background="../images/mail_leftbg.gif"><img src="../images/buttom_left2.gif" width="17" height="17" /></td>
    <td background="../images/buttom_bgs.gif"><img src="../images/buttom_bgs.gif" width="17" height="17"></td>
    <td valign="bottom" background="../images/mail_rightbg.gif"><img src="../images/buttom_right2.gif" width="16" height="17" /></td>
  </tr>
</table>
    </form>
</body>
</html>
