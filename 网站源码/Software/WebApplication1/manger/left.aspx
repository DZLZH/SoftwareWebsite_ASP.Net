<%@ Page Language="C#" AutoEventWireup="true" CodeFile="left.aspx.cs" Inherits="manger_left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>软件特色专业</title>
    <script src="js/prototype.lite.js" type="text/javascript"></script>

    <script src="js/moo.fx.js" type="text/javascript"></script>

    <script src="js/moo.fx.pack.js" type="text/javascript"></script>
    <style type="text/css">
        body
        {
            font: 12px Arial, Helvetica, sans-serif;
            color: #000;
            background-color: #EEF2FB;
            margin: 0px;
        }
        #container
        {
            width: 165px;
        }
        H1
        {
            font-size: 12px;
            margin: 0px;
            width: 165px;
            cursor: pointer;
            height: 30px;
            line-height: 20px;
        }
        H1 a
        {
            display: block;
            width: 165px;
            color: #000;
            height: 30px;
            text-decoration: none;          
            background-image: url(images/menu_bgS.gif);
            background-repeat: no-repeat;
            line-height: 30px;
            text-align: center;
            margin: 0px;
            padding: 0px;
        }
        .content
        {
           width: 165px;
            height: 26px;
        }
        .MM ul
        {
            list-style-type: none;
            margin: 0px;
            padding: 0px;
            display: block;
        }
        .MM li
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            color: #333333;
            list-style-type: none;
            display: block;
            text-decoration: none;
            height: 26px;
            width: 165px;
            padding-left: 0px;
        }
        .MM
        {
          width: 165px;
            margin: 0px;
            padding: 0px;
            left: 0px;
            top: 0px;
            right: 0px;
            bottom: 0px;
            clip: rect(0px,0px,0px,0px);
        }
        .MM a:link
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            color: #333333;
            background-image: url(images/menu_bg1.gif);
            background-repeat: no-repeat;
            height: 26px;
            width: 165px;
            display: block;
            text-align: center;
            margin: 0px;
            padding: 0px;
            overflow: hidden;
            text-decoration: none;
        }
        .MM a:visited
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            color: #333333;
            background-image: url(images/menu_bg1.gif);
            background-repeat: no-repeat;
            display: block;
            text-align: center;
            margin: 0px;
            padding: 0px;
            height: 26px;
            width: 165px;
            text-decoration: none;
        }
        .MM a:active
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            color: #333333;
            background-image: url(images/menu_bg1.gif);
            background-repeat: no-repeat;
            height: 26px;
            width: 165px;
            display: block;
            text-align: center;
            margin: 0px;
            padding: 0px;
            overflow: hidden;
            text-decoration: none;
        }
        .MM a:hover
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            font-weight: bold;
            color: #006600;
            background-image: url(images/menu_bg2.gif);  
            background-repeat: no-repeat;
            text-align: center;
            display: block;
            margin: 0px;
            padding: 0px;
            height: 26px;
            width: 165px;
            text-decoration: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table width="100%" height="280" border="0" cellpadding="0" cellspacing="0" bgcolor="#EEF2FB">
        <tr>
            <td width="172" valign="top">
                <div id="container" runat="server">
                   <img src="images/top.png" alt="" />
                    <h1 class="type" runat="server" id="H1">
                     <a href="javascript:void(0)">新闻中心</a></h1>
                    <div class="content" runat="server" id="Div1">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td>
                                    <img src="images/menu_topline.gif" width="172" height="5" />
                                </td>
                            </tr>
                        </table>
                         <ul class="MM">                            
                            <li><a href="news/newslist.aspx?tid=1" target="main" runat="server" id="A18">列表</a></li> 
                            <li><a href="news/addnews.aspx?tid=1" target="main" runat="server" id="A19">添加</a></li> 
                         </ul>
                    </div>
                    <h1 class="type" runat="server" id="H9">
                        <a href="javascript:void(0)">行业动态</a></h1>
                    <div class="content" runat="server" id="Div9">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td>
                                    <img src="images/menu_topline.gif" width="172" height="5" />
                                </td>
                            </tr>
                        </table>
                         <ul class="MM">                            
                          <li><a href="news/newslist.aspx?tid=10" target="main" runat="server" id="A21">列表</a></li>
                            <li><a href="news/addnews.aspx?tid=10" target="main" runat="server" id="A22">添加</a></li>
                         </ul>
                    </div>
                    <h1 class="type" runat="server" id="H10">
                        <a href="javascript:void(0)">在线学习</a></h1>
                    <div class="content" runat="server" id="Div10">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td>
                                    <img src="images/menu_topline.gif" width="172" height="5" />
                                </td>
                            </tr>
                        </table>
                         <ul class="MM">                            
                            <li><a href="news/newslist.aspx?tid=3" target="main" runat="server" id="A23">列表</a></li> 
                            <li><a href="news/addnews.aspx?tid=3" target="main" runat="server" id="A24">添加</a></li>
                            
                         </ul>
                    </div>
                    
                    <h1 class="type" runat="server" id="H12">
                     <a href="javascript:void(0)">职业素质</a></h1>
                    <div class="content" runat="server" id="Div12">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td>
                                    <img src="images/menu_topline.gif" width="172" height="5" />
                                </td>
                            </tr>
                        </table>
                         <ul class="MM">                            
                            <li><a href="news/newslist.aspx?tid=4" target="main" runat="server" id="A27">列表</a></li> 
                            <li><a href="news/addnews.aspx?tid=4" target="main" runat="server" id="A28">添加</a></li> 
                         </ul>
                    </div>

                    <h1 class="type" runat="server" id="H2">
                    <a href="javascript:void(0)">项目展示</a></h1>
                    <div class="content" runat="server" id="Div2">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td>
                                    <img src="images/menu_topline.gif" width="172" height="5" />
                                </td>
                            </tr>
                        </table>
                         <ul class="MM">                            
                            <li><a href="news/newslist.aspx?tid=5" target="main" runat="server" id="A12">列表</a></li> 
                            <li><a href="news/addnews.aspx?tid=5" target="main" runat="server" id="A14">添加</a></li> 
                         </ul>
                    </div> 

                 <h1 class="type" runat="server" id="hadmin">
                 <a href="javascript:void(0)">用户管理</a></h1>
                <div class="content" runat="server" id="divadmin">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td>
                                <img src="images/menu_topline.gif" width="172" height="5" />
                            </td>
                        </tr>
                    </table>
                    <ul class="MM">
                        <li><a href="admin/Madmin.aspx" target="main" runat="server" id="A6">用户列表</a></li> 
                        <!--<li><a href="base/loglist.aspx" target="main" runat="server" id="A66">管理员登录日志</a></li>  -->   
                    </ul>
                </div>
                
                 <h1 class="type" runat="server" id="RZ">
                 <a href="javascript:void(0)">日志管理</a></h1>
                <div class="content" runat="server" id="divrz">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td>
                                <img src="images/menu_topline.gif" width="172" height="5" />
                            </td>
                        </tr>
                    </table>
                    <ul class="MM">
                       <li><a href="base/loglist.aspx" target="main" runat="server" id="A29">日志管理</a></li>     
                    </ul>
                </div>
                
                 <h1 class="type" runat="server" id="hpw">
                 <a href="javascript:void(0)">修改密码</a></h1>
                <div class="content" runat="server" id="divpw">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td>
                                <img src="images/menu_topline.gif" width="172" height="5" />
                            </td>
                        </tr>
                    </table>
                    <ul class="MM">
                        <li><a href='admin/pwd.aspx' target="main" runat="server" id="A20">修改密码</a></li>                              
                    </ul>
                </div>
                                 
                </div>                
                
                <script type="text/javascript">
                    var contents = document.getElementsByClassName('content');
                    var toggles = document.getElementsByClassName('type');

                    var myAccordion = new fx.Accordion(
			toggles, contents, { opacity: true, duration: 400 });
                    
                </script>

            </td>
        </tr>
    </table>
    </form>
</body>
</html>
