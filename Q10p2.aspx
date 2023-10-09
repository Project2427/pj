<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q10p2.aspx.cs" Inherits="Practical_code_of_awp.Q10p2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>User Information</h2>
            <p>Name: <%= Request.QueryString["name"] %></p>
            <p>Age: <%= Request.QueryString["age"] %></p>
            <p>Email: <%= Request.QueryString["email"] %></p>
            <p>Address: <%= Request.QueryString["address"] %></p>
            <p>Mobile: <%= Request.QueryString["mobile"] %></p>
        </div>
    </form>
</body>
</html>
