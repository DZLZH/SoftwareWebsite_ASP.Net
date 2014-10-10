<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sztz.aspx.cs" Inherits="sztz" %>
<%@ Register Src="~/usercontrol/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/foot.ascx"  TagName="foot" TagPrefix="uc2" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>软件特色专业</title>
    <link href="~/Styles/Styles.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript" src="js/flash.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="Page">
      <uc1:Menu id="Menu" runat="server" />
      <div class="Content">
          <img src="image/结.png"   alt=""/>
          <p style=" font-size:18px; font-weight:bold; text-align:left; padding:10px 50px; "> 团结就是力量</p>
          <div  >
          <script language="javascript" type="text/javascript">
              writeflashhtml("_swf=swf/xixi.swf", "_width=650", "_height=370", "_wmode=transparent");
          </script>

          </div>
      </div>
      <uc2:foot id="foot" runat="server"/>
    </div>
    </form>
</body>
</html>
