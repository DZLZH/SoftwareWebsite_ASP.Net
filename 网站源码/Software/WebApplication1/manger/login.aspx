<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="manger_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        *{ margin:0px auto auto auto;
        }
      body
        {
            margin-left: 0px;
            margin-top: 0px;
            margin-right: 0px;
            margin-bottom: 0px;
            background-color: #1D3647;
     
       
        }
        .style2
        {
            height: 15px;
        }
       .w{ width:1024px; height:768px; background-image:url(images/login.png);}
       .l { width: 381px; height:242px; background-image:url( images/login2.png); float:left; }
       .name { width:300px;  height:21px; padding-top:85px; padding-left:40px;}
       .pwd{ width:300px; height:21px; padding-top:15px; padding-left:40px;}
       .yz{  width:300px; height:21px; padding-top:15px; padding-left:40px;}
       
       .but{ width:300px; height:21px; padding-top:15px; padding-left:40px;}
       .but span { padding-left:30px;}
        </style>

    <script type="text/javascript">
        function correctPNG() {
            var arVersion = navigator.appVersion.split("MSIE")
            var version = parseFloat(arVersion[1])
            if ((version >= 5.5) && (document.body.filters)) {
                for (var j = 0; j < document.images.length; j++) {
                    var img = document.images[j]
                    var imgName = img.src.toUpperCase()
                    if (imgName.substring(imgName.length - 3, imgName.length) == "PNG") {
                        var imgID = (img.id) ? "id='" + img.id + "' " : ""
                        var imgClass = (img.className) ? "class='" + img.className + "' " : ""
                        var imgTitle = (img.title) ? "title='" + img.title + "' " : "title='" + img.alt + "' "
                        var imgStyle = "display:inline-block;" + img.style.cssText
                        if (img.align == "left") imgStyle = "float:left;" + imgStyle
                        if (img.align == "right") imgStyle = "float:right;" + imgStyle
                        if (img.parentElement.href) imgStyle = "cursor:hand;" + imgStyle
                        var strNewHTML = "<span " + imgID + imgClass + imgTitle
             + " style=\"" + "width:" + img.width + "px; height:" + img.height + "px;" + imgStyle + ";"
             + "filter:progid:DXImageTransform.Microsoft.AlphaImageLoader"
             + "(src=\'" + img.src + "\', sizingMethod='scale');\"></span>"
                        img.outerHTML = strNewHTML
                        j = j - 1
                    }
                }
            }
        }
        window.attachEvent("onload", correctPNG);
    </script>

    <link href="images/skin.css" rel="stylesheet" type="text/css" />
</head>
<body style=" background:#000;">
    <form id="form1" runat="server">
     <div class="w">
     <div style="height:257px; width:1024px;"></div>
     <div style=" width:300px; height:100px; float:left;"></div>
      <div class="l">
       <div class="name">
         <span>管理员：&nbsp;&nbsp; </span>
         <asp:TextBox ID="username" class="editbox4" value="" size="20" runat="server"></asp:TextBox>
       </div>
       <div class="pwd">  
          <span >密 码： &nbsp;&nbsp; </span>
          <asp:TextBox ID="userpwd" TextMode="Password" size="20" name="password" runat="server"></asp:TextBox></div>
       <div class="yz">
       <div><span  style="float:left;">验证码：</span>
       <div style="float: left; padding-left:20px;"><asp:TextBox ID="txtValidate"  runat="server"  class="wenbenkuang"  name="verifycode" type="text" value="" MaxLength="5" size="10"></asp:TextBox></div>
       <div align="left">
         <div style="margin-top: 1px; float: left;">
           <span>
             <img alt="点击刷新" id="ImgValidate" onclick="var number = Math.floor(Math.random()*1000+1);this.src='ValidateCode.aspx?'+number;" src="ValidateCode.aspx"/>
           </span>
         </div>
        </div>
        </div>
      </div>
      <div class="but">
      <span><asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/manger/images/UI_15.jpg"  Width="81" Height="31" OnClick="ImageButton2_Click" /></span>
      <span><asp:ImageButton ID="Button1" runat="server" class="button" OnClick="Button1_Click" ImageUrl="~/manger/images/UI_17.jpg"  Width="81" Height="31"/></span>
      </div>
      </div>
    </div>                                         
    </form>
</body>
</html>
