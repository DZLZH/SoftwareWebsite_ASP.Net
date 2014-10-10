<%@ Page Language="C#" AutoEventWireup="true" CodeFile="useradd.aspx.cs" Inherits="manger_admin_useradd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>软件特色专业</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../images/skin.css" rel="stylesheet" type="text/css" />
    <link href="../css/right.css" rel="stylesheet" type="text/css" />
    <link rel="Stylesheet" href="../css/validatorStyle.css" />
    <script src="../../js/jquery-min.js" type="text/javascript"></script>
    <style type="text/css">
    .body
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
            height: 20px;
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
                                <asp:Label ID="lblTitle" runat="server" Text="用户信息"></asp:Label></div>
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
            
           
                <table width="100%" border="0" align="right" cellpadding="3" cellspacing="1"  class="tablecolor">
                                
                                    <tr>
                                        <td align="right" class="tablebody" style="width: 25%;">
                                            真实姓名：
                                        </td>
                                        <td align="left" class="tablebody">
                                            <asp:TextBox ID="txtTrueName"  runat="server" Width="260px" usage="notempty" divMessageId="Label4" tipmsg="请输入真实姓名" tiperror="请输入正是姓名"></asp:TextBox>
                                            &nbsp;
                                            <asp:Label ID="Label4" runat="server" Text="" Height="18px"></asp:Label>&nbsp;
                                        </td>
                                    </tr>
                                    
                                    <tr>
                                        <td align="right" class="tablebody" style="width: 25%;">
                                            学  号：
                                        </td>
                                        <td align="left" class="tablebody">
                                            <asp:TextBox ID="txtLoginName"  runat="server" Width="260px" usage="notempty" divMessageId="Label6" tipmsg="请输入学好" tiperror="请输入学号"></asp:TextBox>
                                            &nbsp;
                                            <asp:Label ID="Label6" runat="server" Text="" Height="18px"></asp:Label>&nbsp;
                                        </td>
                                    </tr>
                                    
                                    <tr>
                                        <td align="right" class="tablebody" style="width: 25%;">
                                           密码：
                                        </td>                                      
                                        <td align="left" class="tablebody">
                                            <asp:TextBox ID="txtPassword"  runat="server" 
                                                Width="260px" usage="notempty" divMessageId="Label7" tipmsg="请输入密码" 
                                                tiperror="请输入密码" Height="20px" Text="000000"></asp:TextBox>&nbsp;
                                            <asp:Label ID="Label7" runat="server" Text="" Height="18px"></asp:Label>
                                            &nbsp;(默认:000000)
                                            <asp:Button ID="btnReSet" runat="server" Text="密码重置" onclick="btnReSet_Click" />
                                        </td>
                                    </tr> 
                                    <tr>
                                        <td align="right" class="tablebody" style="width:25%;">
                                            是否可用：                             </td>
                                        <td align="left" class="tablebody">
                                         <asp:CheckBox ID="ckbIsEnAble" runat="server"  />
                                        </td>
                                    </tr>                                  
                                     <tr>
                                        <td align="right" class="tablebody" style="width: 25%;">
                                            邮箱：
                                        </td>
                                        <td align="left" class="tablebody">
                                            <asp:TextBox ID="txtmail"  runat="server" Width="260px" usage="email" divMessageId="Label2" tipmsg="请输入邮箱(test@163.com)" tiperror="邮箱格式不正确"></asp:TextBox>
                                            &nbsp;
                                            <asp:Label ID="Label2" runat="server" Text="" Height="18px"></asp:Label>
                                        </td>
                                    </tr>  
                                    <tr>
                                        <td align="center" class="tablebody" style="width: 25%;">
                                            &nbsp;
                                     &nbsp;
                                        </td>
                                        <td align="left" class="tablebody">
                                            <asp:Button ID="btnSave" runat="server" Text="保 存"  onclick="btnSave_Click" 
                                                ValidationGroup="a" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   <asp:Button ID="btnBack" runat="server" 
                                                Text="返 回" onclick="btnBack_Click"  check="false" />                                          
                                        </td>
                                    </tr>
                                </table>
                                      
                <asp:HiddenField ID="HiddenField1" runat="server" />
                
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
