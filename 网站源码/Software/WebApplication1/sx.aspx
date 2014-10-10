<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sx.aspx.cs" Inherits="sx" %>
<%@ Register Src="~/usercontrol/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/foot.ascx"  TagName="foot" TagPrefix="uc2" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>软件特色专业</title>
    <link href="~/Styles/Styles.css" rel="stylesheet" type="text/css" />
    <script type=text/javascript src="js/swfobject.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="Page">
      <uc1:Menu id="Menu" runat="server" />
      <div class="Content">
          <img src="image/诚.png"   alt=""/>
          <p style=" font-size:18px; font-weight:bold; text-align:left; padding:10px 50px; "> 实战让我们更茁壮</p>
          <div>
              <div id="loader" align="center">Loading...</div>
              <script type="text/javascript">
                  var so = new SWFObject("swf/viewer.swf", "sotester", "800", "480", "9", "#ffffff");
                  so.addParam("wmode", "opaque");
                  so.addParam("flashvars", "&xmlLocation=nifengla.xml");
                  so.write("loader");
             </script>
          </div>
          <p style="text-align:left; padding:0px 50px;">&nbsp;&nbsp;&nbsp; 通过实训，我们把平时学习的知识点都总结在一起，完成大项目，顿时有一种特别的成就感。虽然实训中我们遇到了很多技术难关，但是凭借着我们对胜利的信念，一点点攻克他们，期间有老师的教导指点，有同学的热心帮助，让我们这个大家庭氛围更浓！
</p>
        </div>
      <uc2:foot id="foot" runat="server"/>
    </div>
    </form>
</body>
</html>