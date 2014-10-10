<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addlink.aspx.cs" Inherits="manger_mlink_addlink" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>软件特色专业</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../images/skin.css" rel="stylesheet" type="text/css" />
    <link href="../css/right.css" rel="stylesheet" type="text/css" />
    <link rel="Stylesheet" href="../css/validatorStyle.css" />
    <style type="text/css">
     body
        {
            margin-left: 0px;
            margin-top: 0px;
            margin-right: 0px;
            margin-bottom: 0px;
            background-color: #EEF2FB;
        }
      
        </style>
    <style type="text/css">
        .tableBorder7
        {
            width: 800;
            border: solid;
            background-color: #eff6ff;
            color: Black;
        }
        TD
        {
            font-family: 宋体;
            font-size: 12px;
            line-height: 15px;
        }
        th
        {
            background-color: #EFEFED;
            color: #EFEFED;
            font-size: 12px;
            font-weight: bold;
        }
        th.th1
        {
            background-color: Silver;
        }
        td.TableBody7
        {
            background-color: #eff6ff;
        }
    </style>
    <style type="text/css">
        body
        {
            font-size: 12px;
            line-height: 20px;
            color: #002f76;
        }
        input
        {
            font-size: 12px;
            }
        .add_biao
        {
            background: url(../images/attach.jpg) no-repeat left center;
            width: 90px;
            color: #002F76;
            padding-left: 22px;
        }
        .rowbg
        {
            border-bottom: #ccc 1px dotted;
        }
        </style>

    <script type="text/javascript" src="../../js/checkform.js"></script>
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
                                <asp:Label ID="lblTitle" runat="server" Text="友情链接"></asp:Label></div>
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
                            <asp:HiddenField ID="hidesort" runat="server" />
                                <table width="100%" border="0" align="center" cellpadding="3" cellspacing="1" class="tablecolor">
                                    <tr>
                                        <td align="center" class="tablebody" style="width: 25%;">
                                            <span style="font-size:9.0pt;font-family:宋体;">网站名称</span>：
                                        </td>
                                        <td align="left" class="tablebody">
                                            &nbsp;
                                            <asp:TextBox ID="txtwebname" runat="server" usage="notempty" 
                                                divMessageId="Label1" tipmsg="请输入网站名称" tiperror="网站名称不能为空" Width="189px"></asp:TextBox>&nbsp;<asp:Label ID="Label1" runat="server" Text="" Height="18px"></asp:Label>
                                        </td>
                                    </tr>
                                      <tr>
                                        <td align="center" class="tablebody" style="width: 25%;">
                                            <span style="font-size:9.0pt;font-family:宋体;">网站地址</span>：
                                        </td>
                                        <td align="left" class="tablebody">
                                            &nbsp;
                                            <asp:TextBox ID="txtwebsite" Text="http://" runat="server" usage="url" 
                                                divMessageId="Label2" tipmsg="请输入网站地址" 
                                                tiperror="网站地址不正确（格式：http://www.abc.com）" Width="189px"></asp:TextBox>&nbsp;<asp:Label ID="Label2" runat="server" Text="" Height="18px"></asp:Label>
                                        </td>
                                    </tr>
                                      <tr>
                                        <td height="25" class="tablebody" align="center">
                                            网站logo：</td>
                                        <td height="25" class="tablebody">
                                            &nbsp; <input id="File1" type="file" runat="server" Width="261px" />&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                                                ID="btnupload" runat="server" Text="上传" Width="48px" check="false" 
                                                onclick="btnupload_Click" />&nbsp;&nbsp;<asp:Label ID="upimage" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                      <tr>
                                        <td align="center" class="tablebody" style="width: 25%;">
                                            <span style="font-size:9.0pt;">添加时间</span>：
                                        </td>
                                        <td align="left" class="tablebody">
                                            &nbsp;
                                            <asp:Label ID="lbltime" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td align="center" class="tablebody" style="width: 25%;">
                                            <span style="font-size:9.0pt;font-family:宋体;">首页显示</span>：
                                        </td>
                                        <td align="left" class="tablebody">
                                            &nbsp;
                                            <asp:CheckBox ID="chkisshow" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="tablebody" style="width: 25%;">
                                            &nbsp;
                                        </td>
                                        <td align="left" class="tablebody">
                                            <asp:Button ID="btnSave" runat="server" Text="修改" onclick="btnSave_Click" />
                                            <asp:Button ID="btnBack" runat="server" Text="返 回" check="false" 
                                                onclick="btnBack_Click" />
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
    </form>
</body>
</html>
