<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MemberManage.Models.Member>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    搜尋結果
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>搜尋結果</h2>

    <table>
        <tr>
            <th></th>
            <th>
                ID
            </th>
            <th>
                Account
            </th>
            <th>
                Password
            </th>
            <th>
                ChName
            </th>
            <th>
                NickName
            </th>
            <th>
                Email
            </th>
            <th>
                CreateTime
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.ID }) %> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.ID },new { onclick = "return confirm('Are you sure?');"})%>

            </td>
            <td>
                <%: item.ID %>
            </td>
            <td>
                <%: item.Account %>
            </td>
            <td>
                <%: item.Password %>
            </td>
            <td>
                <%: item.ChName %>
            </td>
            <td>
                <%: item.NickName %>
            </td>
            <td>
                <%: item.Email %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.CreateTime) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Back to List", "Show") %>
    </p>

</asp:Content>

