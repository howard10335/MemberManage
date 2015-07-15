<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MemberManage.Models.Member>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	修改會員
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>修改會員</h2>

    <% Html.EnableClientValidation(); %>
    <% using (Html.BeginForm("Edit", "Account"))
       {%>       
        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Account) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Account, new Dictionary<string, object>(){{"readonly", "true"}}) %>
                <%: Html.ValidationMessageFor(model => model.Account) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Password) %>
            </div>
            <div class="editor-field">
                <%: Html.PasswordFor(model => model.Password, new Dictionary<string, object>(){{"readonly", "true"}}) %>
                <%: Html.ValidationMessageFor(model => model.Password) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.ChName) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.ChName) %>
                <%: Html.ValidationMessageFor(model => model.ChName) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.NickName) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.NickName) %>
                <%: Html.ValidationMessageFor(model => model.NickName) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Email) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Email) %>
                <%: Html.ValidationMessageFor(model => model.Email) %>
            </div>
            <br/>        
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

</asp:Content>
