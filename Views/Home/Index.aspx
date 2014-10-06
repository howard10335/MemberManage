<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    首頁
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
        若要進一步了解 ASP.NET MVC，請造訪 <a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>。
    </p>
</asp:Content>
