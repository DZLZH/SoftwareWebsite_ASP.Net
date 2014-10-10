<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addfile.aspx.cs" Inherits="manger_downfile_addfile" %>
<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>软件特色专业</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../images/skin.css" rel="stylesheet" type="text/css" />
    <link href="../css/right.css" rel="stylesheet" type="text/css" />
    <link rel="Stylesheet" href="../css/validatorStyle.css" />
   <%-- <script src="../../js/jquery-min.js" type="text/javascript"></script>--%>
  <%--  <script src="../../js/checkform.js" type="text/javascript"></script>--%>
    <style type="text/css">
        .style1
        {
            background-color: #FFFFFF;
            width: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <table width="100%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td width="17" valign="top" background="../images/mail_leftbg.gif">
                <img src="../images/left-top-right.gif" width="17" height="29"  alt=""/>
            </td>
            <td valign="top" background="../images/content-bg.gif">
                <table width="85px" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg"
                    id="table2">
                    <tr>
                        <td height="31">
                            <div class="titlebt">
                                <asp:Label ID="lblTitle" runat="server" Text="文件内容"></asp:Label></div>
                        </td>
                    </tr>
                </table>
            </td>
            <td width="16" valign="top" background="../images/mail_rightbg.gif">
                <img src="../images/nav-right-bg.gif" width="16" height="29" alt=""/>
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
                                <table width="100%" border="0" align="center" cellpadding="3" cellspacing="1" class="tablecolor">
                                    <tr style="display:none;">
                                        <td height="25" class="style1" align="right">
                                            优化标题：</td>
                                        <td height="25" class="tablebody">
                                            <asp:TextBox ID="txtseotitle" Text="默认设置" runat="server" Width="235px" usage="notempty" divMessageId="Label1" tipmsg="请输入优化标题" tiperror="优化标题不能为空"></asp:TextBox>&nbsp;<asp:Label ID="Label1" runat="server" Text="" Height="18px"></asp:Label>&nbsp;(注：此项目不埴写将按系统默认设置操作)
                                        </td>
                                    </tr>
                                     <tr style="display:none;"
                                        <td height="25" class="tablebody" align="right">
                                            优化关键：</td>
                                        <td height="25" class="style1">
                                            <asp:TextBox ID="txtseokeyword" Text="默认设置" runat="server" Width="234px" usage="notempty" divMessageId="Label2" tipmsg="请输入优化关键字" tiperror="优化关键字不能为空"></asp:TextBox>&nbsp;<asp:Label ID="Label2" runat="server" Text="" Height="18px"></asp:Label>&nbsp;(注：此项目不埴写将按系统默认设置操作)
                                        </td>
                                    </tr>
                                     <tr style="display:none;">
                                        <td height="25" class="style1" align="right">
                                            优化描述：</td>
                                        <td height="25" class="tablebody">
                                            <asp:TextBox TextMode="MultiLine" Text="默认设置" ID="txtdescrib" runat="server" Height="49px" 
                                                Width="237px" usage="notempty" divMessageId="Label3" tipmsg="请输入优化描述" tiperror="优化描述不能为空"></asp:TextBox>&nbsp;<asp:Label ID="Label3" runat="server" Text="" Height="18px"></asp:Label>&nbsp;(注：此项目不埴写将按系统默认设置操作)
                                        </td>
                                    </tr>
                                    <tr>
                                        <td height="25" class="style1" align="right">
                                            文件名称：</td>
                                        <td height="25" class="tablebody">
                                             <asp:TextBox ID="txtnewstitle" runat="server" Width="235px" usage="notempty" divMessageId="Label4" tipmsg="请输入新闻名称" tiperror="新闻名称不能为空"></asp:TextBox>&nbsp;<asp:Label ID="Label4" runat="server" Text="" Height="18px"></asp:Label>
                                        </td>
                                    </tr>
                                     <tr style="display:none;">
                                        <td height="25" class="style1" align="right">
                                            文件链接：</td>
                                        <td height="25" class="tablebody">
                                             <asp:TextBox ID="txturl" runat="server" Width="238px" 
                                                 ></asp:TextBox>&nbsp;（格式：http://www.abc.com/file.txt）【注：文件链接或上传文件任选其一】
                                        </td>
                                    </tr>
                                    <tr>
                                        <td height="25" class="style1" align="right">
                                            上传文件：</td>
                                        <td height="25" class="tablebody">
                                             <asp:FileUpload ID="upfile" runat="server" />&nbsp;&nbsp;<asp:Button ID="upbtn" 
                                                 runat="server" Text="上传" check="false" onclick="upbtn_Click" />&nbsp;<asp:Label ID="lblimg" runat="server" style="color:Red;"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td height="25" class="style1" align="right">
                                            浏览次数：</td>
                                        <td height="25" class="tablebody">
                                             <asp:TextBox ID="txtnewsread" runat="server" Text="0" Width="237px" usage="int" divMessageId="Label6" tipmsg="请输入浏览次数" tiperror="浏览次数应该是整数"></asp:TextBox>&nbsp;<asp:Label ID="Label6" runat="server" Text="" Height="18px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="style1">
                                            审核： </td>
                                        <td align="left" class="tablebody">
                                           <asp:CheckBox ID="chkhot" runat="server" Text="审核通过" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="style1">
                                            推荐： </td>
                                        <td align="left" class="tablebody">
                                           <asp:CheckBox ID="chkrem" runat="server" Text="新闻推荐" />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td align="right" class="style1">
                                            添加时间： </td>
                                        <td align="left" class="tablebody">
                                           <asp:Label ID="lbladdtime" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td align="right" class="style1">
                                            新闻内容： </td>
                                        <td align="left" class="tablebody">
                                        <FCKeditorV2:FCKeditor id="txtContent" runat="server"  width='99%' height='350' BasePath="~/manger/fckeditor/">

                                        </FCKeditorV2:FCKeditor>
                                          <%--<asp:TextBox ID="txtContent" runat="server" style="display:none;"></asp:TextBox>
        <IFRAME src='../eWebEditor/ewebeditor.htm?id=txtContent&style=coolblue' frameborder='0' scrolling='no' width='99%' height='350'></IFRAME>--%>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="style1">
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
                <img src="../images/buttom_left2.gif" width="17" height="17" alt=""/>
            </td>
            <td background="../images/buttom_bgs.gif">
                <img src="../images/buttom_bgs.gif" width="17" height="17"alt=""/>
            </td>
            <td valign="bottom" background="../images/mail_rightbg.gif">
                <img src="../images/buttom_right2.gif" width="16" height="17" alt=""/>
            </td>
        </tr>
    </table>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" ShowSummary="False" ValidationGroup="a" />
    </form>
</body>
</html>
