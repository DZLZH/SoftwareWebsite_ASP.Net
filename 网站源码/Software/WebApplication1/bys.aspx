<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bys.aspx.cs" Inherits="brs" %>
<%@ Register Src="~/usercontrol/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/foot.ascx"  TagName="foot" TagPrefix="uc2" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>软件特色专业</title>
    <link href="~/Styles/Styles.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .b1 { width:300px; float:left; margin-left:60px;
        }
        .bys img { width:240px; height:180px;
        }
            .bys p {  margin-top:5px; height:40px; line-height:15px;
            }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div class="Page">
      <uc1:Menu id="Menu" runat="server" />
      <div class="Content">
          <img src="image/梦.png"   alt=""/>
          <p style=" font-size:18px; font-weight:bold; text-align:left; margin:10px 50px; "> 毕业生风采展示
</p>
          <div class="bys">
              <div class="b1">
              <img alt="" src="image/b4.jpg" />
              <p>就业地点：北京<br />就业单位：北京金图科技有限公司<br />就业岗位：java软件工程师</p>
              </div>
              <div class="b1">
              <img alt="" src="image/b2.gif" />
              <p>就业地点：北京 <br />就业单位：智乐软件（北京）有限公司<br />就业岗位：软件测试师</p>
              </div>
              <div class="b1">
              <img alt="" src="image/b3.jpg" />
              <p>就业地点：北京<br />就业单位：北京蓝阵斯康软件开发有限公司<br />就业岗位：java软件工程师</p>
              </div>
              <div class="b1">
              <img alt="" src="image/b1.jpg" />
              <p>就业地点：北京<br /> 就业单位：北京南开创元信息技术有限公司<br />就业岗位：Java工程师</p>
              </div>
          </div>
          <div style="float:left; text-align:center; width:100%; margin-top:10px;"><p><a href="bys.aspx"><<</a>&nbsp;<a href="bys.aspx"><</a>&nbsp;1&nbsp;<a href="bys.aspx">2</a>&nbsp;<a href="bys.aspx">></a>&nbsp; <a href="bys.aspx">>></a>  转到<asp:TextBox ID="TextBox1" runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Width="22px">2</asp:TextBox>页<asp:Button ID="Button1" runat="server" Text="GO" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" /></p></div>
       </div>
      
        <uc2:foot id="foot" runat="server"/>
    </div>
    </form>
</body>
</html>