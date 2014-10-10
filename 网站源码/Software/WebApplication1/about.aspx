<%@ Page Language="C#" AutoEventWireup="true" CodeFile="about.aspx.cs" Inherits="content" %>
<%@ Register Src="~/usercontrol/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/foot.ascx"  TagName="foot" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

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
        <img src="image/专业简介.png" />
            <div class="about">
              <div class="title_about">
                  <strong>当前位置</strong>：<a href="index.aspx">首页</a>  >>专业简介
              </div>
          <div class="jianjie">
         <p align="center" class="bt">软件技术专业特色班简介</p>
          <p><span>主要专业课程</span><br />
          &nbsp;&nbsp;&nbsp;&nbsp;程序设计基础（C语言）、平面图像处理（Photoshop）、动画制作（Flash）、网站前台开发（HTML+DreamWeaver、JavaScript、网站美工设计、网站前台开发技术）、数据库开发（SQL Server、MySQL）、动态网站开发（ASP.NET、PHP）、搜索引擎优化技术（SEO）。<br />
          <span>就业范围</span><br />
          &nbsp;&nbsp;&nbsp;&nbsp;本专业毕业生的就业面向主要是河北省内、京津地区、大连软件技术开发及互联网应用行业。就业范围主要是中小型企业单位的网站设计开发与维护、网络营销推广、Web应用程序设计、制作、测试与维护；数据库设计、开发与维护等相关工作。<br />
          <span>主要从事的工作岗位</span><br />
          &nbsp;&nbsp;&nbsp;&nbsp;(1)	企业中的Web应用程序策划、前台美工设计、后台功能实现以及应用程序的后期维护等职业岗位。<br />
          &nbsp;&nbsp;&nbsp;&nbsp;(2)	中小型企业中从事数据库系统实施、管理与维护岗位。<br />
          &nbsp;&nbsp;&nbsp;&nbsp;(3)	PHP网站、.NET网站开发及电子商务应用开发及测试工作岗位。<br />
          &nbsp;&nbsp;&nbsp;&nbsp;(4)	网站设计规划。<br />
          &nbsp;&nbsp;&nbsp;&nbsp;(5)	软件产品管理与维护、技术支持与软件销售岗位。</p> 
      </div>   
             
          </div>
        </div>
      <uc2:foot ID="foot"  runat="server" />
    </div> 
  </form>
</body>
</html>
