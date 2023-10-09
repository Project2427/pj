<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q10aspx.aspx.cs" Inherits="Practical_code_of_awp.Q10aspx" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>User Information</h2>
            <label for="txtName">Name:</label>
            <asp:TextBox ID="txtName" runat="server" MaxLength="25" />
            <br />
            <label for="txtAge">Age:</label>
            <asp:TextBox ID="txtAge" runat="server" />
            <br />
            <label for="txtEmail">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server" />
            <br />
            <label for="txtAddress">Address:</label>
            <asp:TextBox ID="txtAddress" runat="server" />
            <br />
            <label for="txtMobile">Mobile Number:</label>
            <asp:TextBox ID="txtMobile" runat="server" />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            <br />
            <asp:Label ID="lblErrorMessage" runat="server" ForeColor="#FF3300"></asp:Label>

        </div>
    </form>
</body>
</html>
