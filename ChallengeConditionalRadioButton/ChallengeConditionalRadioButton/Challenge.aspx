<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Challenge.aspx.cs" Inherits="ChallengeConditionalRadioButton.Challenge" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your note taking method<br />
            <br />
            <asp:RadioButton ID="pencilRadio" runat="server" GroupName="notes" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Pencil" />
            <br />
            <asp:RadioButton ID="penRadio" runat="server" GroupName="notes" Text="Pen" />
            <br />
            <asp:RadioButton ID="phoneRadio" runat="server" GroupName="notes" Text="Phone" />
            <br />
            <asp:RadioButton ID="computerRadio" runat="server" GroupName="notes" Text="Computer" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
            <br />
            <br />
            <asp:Image ID="resultImage" runat="server" Height="16px" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
