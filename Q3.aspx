<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q3.aspx.cs" Inherits="Practical_code_of_awp.Q3" %>

<!-- Create simple Web application to perform following. 1) Finding factorial value 2) Money conversion 3)Cube of Given Number 
    4)Genration of Prime Number upto-->

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblFactorial" runat="server" Text="Factorial:"></asp:Label>
            <asp:TextBox ID="txtFactorialInput" runat="server"></asp:TextBox>
            <asp:Button ID="btnCalculateFactorial" runat="server" Text="Calculate Factorial" OnClick="btnCalculateFactorial_Click" />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblMoneyConversion" runat="server" Text="Money Conversion:"></asp:Label>
            <asp:TextBox ID="txtMoneyInput" runat="server"></asp:TextBox>
            <asp:Button ID="btnConvertMoney" runat="server" Text="Convert Money" OnClick="btnConvertMoney_Click" />
            <asp:Label ID="lblResult1" runat="server" Text=""></asp:Label>
            <br />
            <asp:DropDownList ID="ddlCurrency" runat="server">
                <asp:ListItem Text="USD" Value="USD"></asp:ListItem>
                <asp:ListItem Text="CAD" Value="CAD"></asp:ListItem>
                <asp:ListItem Text="EUR" Value="EUR"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblCube" runat="server" Text="Cube of a Number:"></asp:Label>
            <asp:TextBox ID="txtCubeInput" runat="server"></asp:TextBox>
            <asp:Button ID="btnCalculateCube" runat="server" Text="Calculate Cube" OnClick="btnCalculateCube_Click" />
            <asp:Label ID="lblResult2" runat="server" Text=""></asp:Label>
            <br />
            <br />            
            <asp:Label ID="lblPrime" runat="server" Text="Generate Prime Numbers up to:"></asp:Label>
            <asp:TextBox ID="txtMaxPrimeInput" runat="server"></asp:TextBox>
            <asp:Button ID="btnGeneratePrimes" runat="server" Text="Generate Primes" OnClick="btnGeneratePrimes_Click" />
            <asp:Label ID="lblPrimeResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
