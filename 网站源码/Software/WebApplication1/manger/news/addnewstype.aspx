<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addnewstype.aspx.cs" Inherits="manger_news_addnewstype" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>软件特色专业</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../images/skin.css" rel="stylesheet" type="text/css" />
    <link href="../css/right.css" rel="stylesheet" type="text/css" />
    <link rel="Stylesheet" href="../css/validatorStyle.css" />
    <script src="../../js/jquery-min.js" type="text/javascript"></script>
    <script src="../../js/checkform.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
     <table width="100%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td width="17" valign="top" background="../images/mail_leftbg.gif">
                <img src="../images/left-top-right.gif" width="17" height="29" />
            </td>
            <td valign="top" background="../images/content-bg.gif">
                <table width="85px" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg"
                    id="table2">
                    <tr>
                        <td height="31">
                            <div class="titlebt">
                                <asp:Label ID="lblTitle" runat="server" Text="新闻类型"></asp:Label></div>
                        </td>
                    </tr>
                </table>
            </td>
            <td width="16" valign="top" background="../images/mail_rightbg.gif">
                <img src="../images/nav-right-bg.gif" width="16" height="29" />
            </td>
        </tr>
        <tr>
            <td valign="middle" background="../images/mail_leftbg.gif">
                &nbsp;
            </td>
            <td valign="top" bgcolor="#F7F8F9">
                <table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
                    <tr>
                        <td colspan="2" valign="top">
                            
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td valign="top">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div>
                                <table width="100%" border="0" align="center" cellpadding="3" cellspacing="1" class="tablecolor">
                                    <tr>
                                        <td height="25" class="tablebody" align="right">
                                            分类名称：</td>
                                        <td height="25" class="tablebody">
                                            <asp:TextBox ID="txttypename" runat="server" Width="237px" usage="notempty" divMessageId="Label1" tipmsg="请输入分类名称" tiperror="分类名称不能为空"></asp:TextBox>&nbsp;<asp:Label ID="Label1" runat="server" Text="" Height="18px"></asp:Label>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td height="25" class="tablebody" align="right">
                                            父分类：</td>
                                        <td height="25" class="tablebody">
                                            <asp:DropDownList ID="ddlparent" runat="server" Width="240px"></asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td height="25" class="tablebody" align="right">
                                            序号：</td>
                                        <td height="25" class="tablebody">
                                            <asp:TextBox ID="txtsort" runat="server" Text="0" Width="237px" usage="int" divMessageId="Label2" tipmsg="请输入序号" tiperror="序号只能是整数"></asp:TextBox>&nbsp;<asp:Label ID="Label2" runat="server" Text="" Height="18px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="tablebody" style="width: 25%;">
                                            审核： </td>
                                        <td align="left" class="tablebody">
                                           <asp:CheckBox ID="chkhot" runat="server" Text="审核通过" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="tablebody" style="width: 25%;">
                                            &nbsp;
                                        </td>
                                        <td align="left" class="tablebody">
                                            <asp:Button ID="btnSave" runat="server" Text="保 存" onclick="btnSave_Click" 
                                                ValidationGroup="a" Width="88px" />
                                                &nbsp;&nbsp;
                                            <asp:Button ID="btnBack" runat="server" Text="返 回" check="false" 
                                                onclick="btnBack_Click" Width="83px" />
                                                <asp:HiddenField ID="hidetypeid" runat="server" />
                                                <asp:Label ID="lbldepth" runat="server" Visible="false"></asp:Label>
                                                <asp:Label ID="lblrootid" runat="server" Visible="false"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
            <td background="../images/mail_rightbg.gif">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td valign="bottom" background="../images/mail_leftbg.gif">
                <img src="../images/buttom_left2.gif" width="17" height="17" />
            </td>
            <td background="../images/buttom_bgs.gif">
                <img src="../images/buttom_bgs.gif" width="17" height="17">
            </td>
            <td valign="bottom" background="../images/mail_rightbg.gif">
                <img src="../images/buttom_right2.gif" width="16" height="17" />
            </td>
        </tr>
    </table>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" ShowSummary="False" ValidationGroup="a" />
    </form>
</body>
</html>
