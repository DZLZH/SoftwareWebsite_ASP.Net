<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ekzgzs.aspx.cs" Inherits="ekzgzs" %>
<%@ Register Src="~/usercontrol/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/foot.ascx"  TagName="foot" TagPrefix="uc2" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>软件特色专业</title>
    <link href="~/Styles/Styles.css" rel="stylesheet" type="text/css" />
    
</head>
<body>
    <form id="form1" runat="server">
    <div class="Page">
      <uc1:Menu id="Menu" runat="server" />
      <div class="Content">
          <img src="image/创.png"   alt=""/>
          <p style=" font-size:18px; font-weight:bold; text-align:left; padding:10px 50px; ">e科技工作室</p>
          <div style="width:60%; height:60%;"><img src="image/7.jpg" style="width:100%; height:100%;"/></div>
          <div  style="margin-top:30px;width:80%; text-align:left;"><p >&nbsp;&nbsp;&nbsp;&nbsp;E科技工作室创建于2012年3月，在这科技信息时代E科技工作室成为学校之中必不可少的社团，我们以创造E时代的新型人才为目标并以企业化模式进行运作。现在E科技工作室拥有六个部门共同开拓创新，同时与相关企业进行合作为培养人才、服务学校与社会努力拼搏。</p></div>
      </div>
      <uc2:foot id="foot" runat="server"/>
    </div>
    </form>
</body>
</html>