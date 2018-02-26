<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calc.aspx.cs" Inherits="ChallengeSimpleCalculator.Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
        </div>
        <p>
            <span class="auto-style1">First Value</span>&nbsp;
            <asp:TextBox ID="firstInput" runat="server" OnTextChanged="firstInput_TextChanged"></asp:TextBox>
        </p>
        <p>
            <span class="auto-style1">Second Value</span>&nbsp;
            <asp:TextBox ID="secondInput" runat="server" OnTextChanged="secondInput_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="*" />
&nbsp;
            <asp:Button ID="subButton" runat="server" OnClick="subButton_Click" Text="-" />
&nbsp;
            <asp:Button ID="multButton" runat="server" OnClick="multButton_Click" Text="*" />
&nbsp;
            <asp:Button ID="divButton" runat="server" OnClick="divButton_Click" Text="/" />
        </p>
        <asp:Label ID="resultLabel" runat="server" BackColor="#3366FF" style="font-weight: 700; font-size: medium"></asp:Label>
    </form>
</body>
</html>
