<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addnews.aspx.cs" Inherits="manger_news_addnews" %>
<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>软件特色专业</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
                                <asp:Label ID="lblTitle" runat="server" Text="新闻内容"></asp:Label></div>
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
                            <asp:HiddenField ID="hidetypeid" runat="server" />
                                <asp:HiddenField ID="hdftype" runat="server" />
                                <table width="100%" border="0" align="center" cellpadding="3" cellspacing="1" class="tablecolor">
                                    
                                    <tr>
                                        <td height="25" class="tablebody" align="right">
                                            新闻名称：</td>
                                        <td height="25" class="tablebody">
                                             <asp:TextBox ID="txtnewstitle" runat="server" Width="235px" usage="notempty" divMessageId="Label4" tipmsg="请输入新闻名称" tiperror="新闻名称不能为空"></asp:TextBox>&nbsp;<asp:Label ID="Label4" runat="server" Text="" Height="18px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td height="25" class="tablebody" align="right">
                                            新闻类别：</td>
                                        <td height="25" class="tablebody">
                                             <asp:DropDownList ID="ddlnewstype" runat="server" Width="239px"></asp:DropDownList>
                                        </td>
                                    </tr>
                                     
                                     <tr>
                                        <td height="25" class="tablebody" align="right">
                                            新闻来源：</td>
                                        <td height="25" class="tablebody">
                                            <asp:TextBox ID="txtnewscomefrom" runat="server" Width="238px" usage="notempty" divMessageId="Label51" Text="计算机系" tipmsg="请输入新闻来源" tiperror="新闻来源不能为空"></asp:TextBox>&nbsp;<asp:Label ID="Label51" runat="server" Text="" Height="18px"></asp:Label>
                                        </td>
                                    </tr>
                                  
                                    <tr>
                                        <td height="25" class="tablebody" align="right">
                                            浏览次数：</td>
                                        <td height="25" class="tablebody">
                                             <asp:TextBox ID="txtnewsread" runat="server" Text="0" Width="237px" usage="int" divMessageId="Label6" tipmsg="请输入浏览次数" tiperror="浏览次数应该是整数"></asp:TextBox>&nbsp;<asp:Label ID="Label6" runat="server" Text="" Height="18px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="tablebody" style="width: 25%;">
                                            审核： </td>
                                        <td align="left" class="tablebody">
                                           <asp:CheckBox ID="chkhot" runat="server" Text="审核通过" Checked="True" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="tablebody" style="width: 25%;">
                                            推荐： </td>
                                        <td align="left" class="tablebody">
                                           <asp:CheckBox ID="chkrem" runat="server" Text="推荐" />
                                           <asp:RadioButton ID="RadioButton1" runat="server" Text="是否置顶" />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td align="right" class="tablebody" style="width: 25%;">
                                            添加时间： </td>
                                        <td align="left" class="tablebody">
                                          
                                            <asp:TextBox ID="lbladdtime" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td align="right" class="tablebody" style="width: 25%;">
                                            修改时间： </td>
                                        <td align="left" class="tablebody">
                                          
                                            <asp:TextBox ID="lblaltertime" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td align="right" class="tablebody" style="width: 25%;">
                                            新闻内容： </td>
                                        <td align="left" class="tablebody">
                                        <FCKeditorV2:FCKeditor id="txtContent" runat="server"  width='99%' height='350' BasePath="~/manger/fckeditor/">

                                           </FCKeditorV2:FCKeditor>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="tablebody" style="width: 25%;">
  &nbsp;
                                        </td>
                                        <td align="left" class="tablebody">
                                            <asp:Button ID="btnSave" runat="server" Text="保 存" onclick="btnSave_Click" 
                                                ValidationGroup="a" Width="59px" />&nbsp;&nbsp;&nbsp;
                                            <asp:Button ID="btnBack" runat="server" Text="返 回" check="false" 
                                                onclick="btnBack_Click" Width="65px" />
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
