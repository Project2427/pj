<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q11.aspx.cs" Inherits="Practical_code_of_awp.Q11" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <p>Inside the Update Panel</p>
                    <p>
                        <asp:Button ID="Button1" runat="server" Text="Partial PostBack" OnClick="Button1_Click" />
                    </p>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>


            <p>Outside the Update Panel</p>
            <p>
                <asp:Button ID="btntotal" runat="server" OnClick="btntotal_Click" Text="Total PostBack" />
            </p>
            <asp:Label ID="lbltotal" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
