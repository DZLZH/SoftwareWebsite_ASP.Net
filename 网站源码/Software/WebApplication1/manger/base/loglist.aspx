<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loglist.aspx.cs" Inherits="manger_base_loglist" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>软件特色专业</title>
    <link href="../images/skin.css" rel="stylesheet" type="text/css" />   
    <script src="../../js/checkform.js" type="text/javascript"></script>
    <script type="text/javascript">
        function checkedAll(v) {
            var inputCkb = document.getElementsByName("checkbox");
            for (i = 1; i < inputCkb.length; i++)
                inputCkb[i].checked = v.checked;
        }
    </script>
    </head>
<body>
<form id="form1" runat="server">
<table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="17" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt"><span lang="zh-cn">日志</span>列表</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9"><table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td valign="top">&nbsp;
<table width="100%" align="center" border="1" cellpadding="0" cellspacing="0" bordercolorlight="#999999" bordercolordark="#FFFFFF" class="newtable">
      <tr>
        <td colspan="6" style="background:#bfd3e6; text-align:left">&nbsp;&nbsp;&nbsp;&nbsp;
              搜索关键字：<input id="key" type="text" runat="server" size="35" maxlength="100" onfocus="getb(this)" onblur="getbno(this)" />&nbsp;
              
              <asp:Button ID="btnQuery" runat="server" Text="搜索" Height="25px"  onclick="btnQuery_Click" />
          </td>
      </tr>
      <tr>
      <td colspan="6" height="5px"></td>
      </tr>
	  <tr style=" font-size:14px;" id="titleone">
	    <%--<td width="6" align="center" bgcolor="#e1e5ee"><input id="chkAll" runat="server" type="checkbox" onclick="checkAll(this)" /></td>--%>
		<td width="10%" align="center" bgcolor="#e1e5ee">ID</td>		
		<td width="20%" align="center" bgcolor="#e1e5ee">登录时间</td>
		<td width="40%" align="center" bgcolor="#e1e5ee">登录内容</td>
		<td width="20%" align="center" bgcolor="#e1e5ee">登录IP</td>
		<td width="10%" align="center" bgcolor="#e1e5ee">操作</td>
	  </tr>
	  <asp:Repeater ID="rptNewslist" runat="server" 
          onitemcommand="rptNewslist_ItemCommand">
      <ItemTemplate>
	  <tr onmouseover="this.style.backgroundColor='#e1e5ee';" onmouseout="this.style.backgroundColor='';">
	   <%-- <td align="center">&nbsp;<input type="checkbox" name="checkbox" value='<%#Eval("log_id") %>' /></td>--%>
		<td align="center">&nbsp;<%#Eval("log_id")%></td>
		<td align="center">&nbsp;<%# Eval("log_time")%></td>
		<td align="center">&nbsp;<%#Eval("log_note")%></td>
		<td align="center">&nbsp;<%#Eval("log_ip")%></td>
		<td align="center">&nbsp;<asp:LinkButton ID="LinkButton1" runat="server" CommandName="delete" CommandArgument='<%#Eval("log_id") %>' OnClientClick="return confirm('确认删除吗?')">删除</asp:LinkButton></td>
	  </tr>
	  </ItemTemplate>
      </asp:Repeater>
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
