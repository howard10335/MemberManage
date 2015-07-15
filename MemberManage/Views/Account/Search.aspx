<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	查詢會員
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>查詢會員</h2>

    <% using (Html.BeginForm()) { %>
          <div>
              <p>
                  <label for="SearchText">請輸入查詢字串:</label>
                  <%: Html.TextBox("SearchText")%>
              </p>
              <p>
                  <input class="classiclogon" type="submit" value="查詢" />
              </p>
          </div>
    <% } %>

</asp:Content>
