<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MemberManage.Models.LogOnModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	會員登入
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>會員登入</h2>

    <%Html.EnableClientValidation(); %>

    <% using (Html.BeginForm()) { %>
          <div>
              <p>
                  <label for="username">帳號:</label>
                  <%: Html.TextBoxFor(model => model.UserName)%>
                  <%: Html.ValidationMessageFor(model => model.UserName)%>
              </p>
              <p>
                  <label for="password">密碼:</label>
                  <%: Html.PasswordFor(model => model.Password)%>
                  <%: Html.ValidationMessageFor(model => model.Password)%>
              </p>
              <p>
                  <input class="classiclogon" type="submit" value="登入" />
              </p>
              <p>
                  請輸入您的帳號密碼。若是沒有帳號密碼，請前往 <%: Html.ActionLink("註冊帳號", "Register") %>。
              </p>
          </div>
    <% } %>

</asp:Content>
