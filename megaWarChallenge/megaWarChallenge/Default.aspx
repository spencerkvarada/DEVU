<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="megaWarChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="playWarButton" runat="server" OnClick="playWarButton_Click" Text="Play War!" />
            <br />
            <br />
            <br />
        </div>
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
