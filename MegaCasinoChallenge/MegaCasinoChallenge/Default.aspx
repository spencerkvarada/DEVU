<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaCasinoChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="reel1" runat="server" Height="150px" Width="151px" />
            <asp:Image ID="reel2" runat="server" Height="150px" Width="151px" />
            <asp:Image ID="reel3" runat="server" Height="150px" Width="151px" />
            <br />
            <br />
            You Bet:&nbsp;
            <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="leverButton" runat="server" OnClick="leverButton_Click" Text="Press to gamble!" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="moneyLabel" runat="server"></asp:Label>
            <br />
            <br />
            1 Cherry = double your bet!<br />
            2 Cherries = triple your bet!<br />
            3 Cherries = quadruple your bet!<br />
            3 7&#39;s = Jackpot! 100x your bet!<br />
            HOWEVER: Bar = immediate loss no matter the others.</div>
    </form>
</body>
</html>
