<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FortuneTeller.aspx.cs" Inherits="DevUChallenge1.FortuneTeller" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            How old are you?&nbsp;
            <asp:TextBox ID="ageBox" runat="server"></asp:TextBox>
            <br />
            <br />
            How much money do you have in your pocket?&nbsp;
            <asp:TextBox ID="moneyBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="fortuneButton" runat="server" OnClick="fortuneButton_Click" Text="See your fortune" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" Text="resultLabel"></asp:Label>
        </div>
    </form>
</body>
</html>
