<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newstype.aspx.cs" Inherits="manger_news_newstype" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>软件特色专业</title>
    <link href="../images/skin.css" rel="stylesheet" type="text/css" />
       <link href="../css/validatorStyle.css" rel="stylesheet" type="text/css" />

    <script src="../../js/checkform.js" type="text/javascript"></script>
</head>
<body>
<form id="form1" runat="server">
<input id="hdnfid" runat="server" type="hidden" />
<table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="17" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" height="29" /></td>
    <td valign="top" background="../images/content-bg.gif"><table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg" id="table2">
      <tr>
        <td height="31"><div class="titlebt">新闻类别</div></td>
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
        <td colspan="5" style="background:#bfd3e6; text-align:left" >
&nbsp;
                <asp:Button 
                ID="btnAdd" runat="server" Text="添加" Height="25px" 
                onclick="btnAdd_Click1"/>&nbsp;<asp:Label ID="Label3" runat="server" Text="" Height="18px"></asp:Label>
         </td>
      </tr>
	 <tr>
	 <td height="5px"></td>
	 </tr>
	 <asp:DataList ID="NFtype" runat="server" Width="100%" DataKeyField="n_type_id" onitemcommand="NFtype_ItemCommand">
	 <HeaderTemplate>
	  <tr style=" font-size:14px;" id="titleone">
	    <td width="30%" align="center" bgcolor="#e1e5ee">类别名称</td>
		<td width="30%" align="center" bgcolor="#e1e5ee">父分类节点</td>
		<td width="10%" align="center" bgcolor="#e1e5ee">审核</td>
		<td width="10%" align="center" bgcolor="#e1e5ee">排序</td>
		<td width="20%" align="center" bgcolor="#e1e5ee">操作</td>
	  </tr>
	 </HeaderTemplate>
	 <ItemTemplate>
	 <asp:HiddenField ID="hdfId" Value='<%# Eval("n_type_id") %>' runat="server" />
	  <tr onmouseover="this.style.backgroundColor='#e1e5ee';" onmouseout="this.style.backgroundColor='';">
	    <td width="30%" align="center"><%# hh(Eval("n_type_name"), Eval("n_type_depth"))%></td>
	     <td width="30%" align="center"><%# parentID(Eval("n_type_parentid"))%></td>
	      <td width="10%" align="center"><asp:LinkButton ToolTip="审核后前台显示" ID="lbtshenhe" Text='<%#Getshenhe(Eval("n_type_isshow"))%>' ForeColor='<%#GetshenheColor(Eval("n_type_isshow"))%>' runat="server" CommandName='<%#Eval("n_type_isshow") %>' CommandArgument='<%#Eval("n_type_id") %>'></asp:LinkButton></td>
		<td width="10%" align="center" title="数值越大前台越靠前显示">
		<%# Eval("n_type_sort") %>
		</td>
		<td width="20%" align="center">
		<a href="addnewstype.aspx?id=<%#Eval("n_type_id") %>">修改</a> | <asp:LinkButton ID="LinkButton1" runat="server" CommandName="delete" CommandArgument='<%#Eval("n_type_id") %>' OnClientClick="return confirm('确认删除吗?')">删除</asp:LinkButton>
		</td>
	  </tr>
	 </ItemTemplate>
	 <FooterTemplate>
	 <tr>
		<td colspan="5" align="center">
		
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
	 </FooterTemplate>
	 </asp:DataList> 
	<table widt="100%" align="center">
	<tr>
	<td>
	&nbsp;
	</td>
	</tr>
	</table>
</form>
</body>
</html>
