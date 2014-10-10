<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pwd.aspx.cs" Inherits="manger_admin_pwd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>软件特色专业</title>
    <link href="../images/skin.css" rel="stylesheet" type="text/css" />
    <script src="../../js/checkform.js" type="text/javascript"></script>
    <script src="../../js/jquery-1.3.min.js" type="text/javascript"></script>
    <style type="text/css">
        .style1
        {
            height: 26px;
        }
    </style>
    <script  type="text/javascript">
        function checkforms() {
            if ($("#pwd0").val() == "") {
                alert("请输入原密码...");
                return false;
            } else if ($("#pwd1").val() == "") {
                alert("请输入新密密码...");
                return false;
            } else if ($("#pwd2").val() == "") {
                alert("请输入重复密码...");
                return false;
            } else if ($("#pwd1").val() != $("#pwd2").val()) {
                alert("重复密码与原密码不同...");
                return false;
            }
            else {
                return true;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <input id="hdnfid" runat="server" type="hidden" />
<table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="17" valign="top" background="../images/mail_leftbg.gif"><img src="../images/left-top-right.gif" width="17" 

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
        <br />
    <table width="60%" style="font-size:12px;">
        <tr><td align="right" class="style1">原密码：</td><td align="left" class="style1"><input id="pwd0" runat="server"  type="password"/></td></tr>
        <tr><td align="right">新密码：</td><td align="left"><input id="pwd1" runat="server"  type="password"/></td></tr>
        <tr><td align="right">重复密码：</td><td align="left"><input id="pwd2" runat="server"  type="password"/></td></tr>
        <tr><td align="right">
            <asp:Button ID="btnEdit" runat="server" Text=" 修 改 " 
                OnClientClick="return checkforms()" onclick="btnEdit_Click" />&nbsp;&nbsp;</td><td align="left">&nbsp;&nbsp;<input id="btnreset" type="reset"
                value=" 重 置 " /></td></tr>
    </table>

        </td>
      </tr>
    </table></td>
    <td background="../images/mail_rightbg.gif">&nbsp;</td>
  </tr>
  <tr>
    <td valign="bottom" background="../images/mail_leftbg.gif"><img src="../images/buttom_left2.gif" width="17" height="17" /></td>
    <td background="../images/buttom_bgs.gif"></td>
    <td valign="bottom" background="../images/mail_rightbg.gif"><img src="../images/buttom_right2.gif" width="16" height="17"  

/></td>
  </tr>
</table>
    </form>
</body>
</html>
