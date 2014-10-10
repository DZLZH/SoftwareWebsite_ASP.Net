<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Madmin.aspx.cs" Inherits="manger_admin_Madmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>软件特色专业</title>
    <link href="images/skin.css" rel="stylesheet" type="text/css" />
    <script src="../../js/checkform.js" type="text/javascript"></script>
    <script src="../../js/jquery.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <input id="hdnfid" runat="server" type="hidden" />
<table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="17" valign="top" style="background:'../images/mail_leftbg.gif'"><img src="../images/left-top-right.gif" width="17" 

height="29" /></td>
    <td valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" 

cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">管理员</div></td>
      </tr>
    </table></td>
    <td width="16" valign="top" background="../images/mail_rightbg.gif"><img src="../images/nav-right-bg.gif" width="16" 

height="29" /></td>
  </tr>
  <tr>
    <td valign="middle" background="../images/mail_leftbg.gif">&nbsp;</td>
    <td valign="top" bgcolor="#F7F8F9">
    <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td valign="top">
<table width="100%" align="center" border="1" cellpadding="0" cellspacing="0" bordercolorlight="#999999" 

bordercolordark="#FFFFFF" class="newtable">
      <tr>
        <td colspan="7" style="background:#bfd3e6; text-align:left" >
            &nbsp;
              添加管理员&nbsp;&nbsp;&nbsp;用户名：<input id="txtname" type="text" runat="server" onfocus="getb(this)" onblur="getbno(this)" />&nbsp;密码：<input id="txtpwd"  onfocus="getb(this)" onblur="getbno(this)" type="text" runat="server" />
                
               角色： <asp:DropDownList ID="ddrole" runat="server">
                <asp:ListItem Value="1">超级管理员</asp:ListItem>
                <asp:ListItem Value="2">内容管理员</asp:ListItem>
            </asp:DropDownList>
                
                <asp:Button 
                ID="btnAdd" runat="server" Text="添加" Height="25px" onclick="btnAdd_Click"/>
         </td>
      </tr>
	 <tr>
	 <td colspan="7" height="5px"></td>
	 </tr>
	 <tr>
	 <td>
	 <asp:DataList ID="dldtype" runat="server" Width="100%" 
          oncancelcommand="dldtype_CancelCommand" ondeletecommand="dldtype_DeleteCommand" 
          oneditcommand="dldtype_EditCommand" onupdatecommand="dldtype_UpdateCommand"
          DataKeyField="user_id">
	 <HeaderTemplate>
	  <tr style=" font-size:14px;" id="titleone">
	    <td width="10%" align="center" bgcolor="#e1e5ee">编号</td>
		<td width="10%" align="left" bgcolor="#e1e5ee">管理员名称</td>
		<td width="15%" align="left" bgcolor="#e1e5ee">管理员密码(加密)</td>
		<td width="20%" align="left" bgcolor="#e1e5ee">创建时间</td>
		<td width="20%" align="left" bgcolor="#e1e5ee">最后登录时间</td>
		<td width="15%" align="left" bgcolor="#e1e5ee">最后登录IP</td>
		<td width="10%" align="center" bgcolor="#e1e5ee">操作</td>
	  </tr>
	 </HeaderTemplate>
	 <ItemTemplate>
	  <tr onmouseover="this.style.backgroundColor='#e1e5ee';" onmouseout="this.style.backgroundColor='';">
	    <td width="10%" align="center"><%# Container.ItemIndex+1 %></td>
		<td width="10%" align="left"><%# Eval("user_name")%></td>
		<td width="15%" align="left"><%# Eval("user_password").ToString().Length > 10 ? Eval("user_password").ToString

().Substring(0, 10) : Eval("user_password").ToString()%></td>
		<td width="20%" align="left"><%# Eval("user_createtime")%></td>
		<td width="20%" align="left"><%# Eval("user_logintime")%></td>
		<td width="15%" align="left"><%# Eval("user_ip")%></td>
		<td width="10%" align="center" style="min-width:100px"><asp:LinkButton ID="lbtnalert" runat="server" CommandName="edit" Text="修改"></asp:LinkButton> | <asp:LinkButton ID="LinkButton1" OnClientClick="return confirm('确定删除吗？')" runat="server" 

CommandName="delete" Text="删除"></asp:LinkButton></td>
	  </tr>
	 </ItemTemplate>
	 <EditItemTemplate>
	 <tr onmouseover="this.style.backgroundColor='#e1e5ee';" onmouseout="this.style.backgroundColor='';">
	    <td width="10%" align="center"><%# Container.ItemIndex+1 %></td>
		<td width="10%" align="left"><asp:TextBox ID="txtuser" BackColor="#FFEE62" runat="server" Text='<%# Eval

("user_name")%>'></asp:TextBox></td>
		<td width="15%" align="left"><asp:TextBox ID="txtpass" runat="server" BackColor="#FFEE62" Text=''></asp:TextBox></td>
		<td width="20%" align="left"><%# Eval("user_createtime")%></td>
		<td width="20%" align="left"><%# Eval("user_logintime")%></td>
		<td width="15%" align="left"><%# Eval("user_ip")%></td>
		<td width="10%" align="center" style="min-width:100px"><asp:LinkButton ID="lbtnalert" runat="server" CommandName="update" Text="更新"></asp:LinkButton> | <asp:LinkButton ID="LinkButton1" runat="server" CommandName="cancel" Text="取消"></asp:LinkButton></td>
	  </tr>
	 </EditItemTemplate>
	 </asp:DataList>
	 </td>
	 </tr> 
	 <tr>
		<td colspan="7" align="center">
		&nbsp;
        </td>
	  </tr>
</table> 
        </td>
      </tr>
    </table></td>
    <td background="images/mail_rightbg.gif">&nbsp;</td>
  </tr>
  <tr>
    <td valign="bottom" background="../images/mail_leftbg.gif"><img src="../images/buttom_left2.gif" width="17" height="17" 

/></td>
    <td background="images/buttom_bgs.gif"></td>
    <td valign="bottom" background="../images/mail_rightbg.gif"><img src="../images/buttom_right2.gif" width="16" height="17"     

/></td>
  </tr>
</table>
<asp:HiddenField ID="HiddenField1" runat="server" />
    </form>
</body>
</html>
