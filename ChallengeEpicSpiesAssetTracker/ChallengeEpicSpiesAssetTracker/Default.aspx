<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 190px;
            height: 238px;
        }
    </style>
</head>
<body style="font-weight: 700">
    <form id="form1" runat="server">
        <div>
            <img alt="" class="auto-style1" src="file:///C:/Users/Spencer/Documents/VSProjects/CS-ASP_019-Challenge/epic-spies-logo.jpg" /><br />
            <br />
            Asset Performance Tracker<br />
            <br />
            Asset Name:&nbsp;
            <asp:TextBox ID="assetBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Elections Rigged:&nbsp;
            <asp:TextBox ID="electionBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Acts of Subterfuge Performed:&nbsp;
            <asp:TextBox ID="subBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
