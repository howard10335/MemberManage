﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default</title>
</head>
<body>
    <div>
        <%: Html.ActionLink("MVC版本", "Index") %>
        <br />
        <%: Html.ActionLink("Silverlight版本", "LogOn", "Silverlight") %>
    </div>
</body>
</html>
