<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_top.aspx.cs" Inherits="manger_admin_top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>软件特色专业</title>
    <link href="images/skin.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript">
        function logout() {
            if (confirm("您确定要退出控制面板吗？"))
                top.location = "out.aspx";
            return false;
        }
        function logoutt() {
            window.open("../index.aspx");
        }
    </script>

    <script type="text/javascript">
        function showsubmenu(sid) {
            var whichEl = eval("submenu" + sid);
            var menuTitle = eval("menuTitle" + sid);
            if (whichEl.style.display == "none") {
                eval("submenu" + sid + ".style.display=\"\";");
            } else {
                eval("submenu" + sid + ".style.display=\"none\";");
            }
        }
    </script>

    <script type="text/javascript">
        function showsubmenu(sid) {
            var whichEl = eval("submenu" + sid);
            var menuTitle = eval("menuTitle" + sid);
            if (whichEl.style.display == "none") {
                eval("submenu" + sid + ".style.display=\"\";");
            } else {
                eval("submenu" + sid + ".style.display=\"none\";");
            }
        }
    </script>

    <base target="main" />
    <style type="text/css">
        .style1
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            color: #FFFFFF;
            text-decoration: none;
            height: 38px;
            width: 70%;
          
            line-height: 38px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <div>
        <table width="100%" height="64" border="0" cellpadding="0" cellspacing="0" class="admin_topbg">
            <tr>
                <td width="61%" height="64">
                    <img src="images/logo.gif" width="262" height="64" alt="" style="margin-top:-2px;"/>
                </td>
                <td width="39%" valign="top">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td height="38" class="style1">
                                管理员：<b><%=Session["Mname"]%></b>，您好,感谢登陆使用！</td>
                            <td width="10%">
                                <a href="../index.aspx"target="_blank" onclick="javascript:parent.location.href('../index.aspx');" >
                                    <img src="images/out2.gif"  alt="打开首页" width="70" height="20" border="0" style=" margin-top:10px;"/></a>&nbsp;
                            </td>
                            <td width="5%">
                                <a href="#" target="_self"  onclick="logout();"><img src="images/out.gif" alt="安全退出"
                                            width="46" height="20" border="0" style="float:left; margin-top:10px;"/></a>&nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td height="19" colspan="3">
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
