<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="epicspieschallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="font-weight: 700; font-size: large; font-family: Georgia, 'Times New Roman', Times, serif">
    <form id="form1" runat="server">
        <p>
            Spy New Assignment Form</p>
        <p style="font-size: medium; font-family: Arial, Helvetica, sans-serif">
            &nbsp;&nbsp;Spy Code Name:&nbsp;
            <asp:TextBox ID="codeBox" runat="server"></asp:TextBox>
        </p>
        <p style="font-size: medium; font-family: Arial, Helvetica, sans-serif">
            &nbsp; New Assignment Name:&nbsp;
            <asp:TextBox ID="assignmentbox" runat="server"></asp:TextBox>
        </p>
        <p style="font-size: medium; font-family: Arial, Helvetica, sans-serif">
            End date of previous assignment:</p>
        <p style="font-size: medium; font-family: Arial, Helvetica, sans-serif">
            <asp:Calendar ID="endoldCalendar" runat="server"></asp:Calendar>
        </p>
        <p style="font-size: medium; font-family: Arial, Helvetica, sans-serif">
            Start date of next assignment:</p>
        <p style="font-size: medium; font-family: Arial, Helvetica, sans-serif">
            <asp:Calendar ID="startnewCalendar" runat="server"></asp:Calendar>
        </p>
        <p style="font-size: medium; font-family: Arial, Helvetica, sans-serif">
            Proposed end date of next assignment:</p>
        <p style="font-size: medium; font-family: Arial, Helvetica, sans-serif">
            <asp:Calendar ID="endnewCalendar" runat="server"></asp:Calendar>
        </p>
        <p style="font-size: medium; font-family: Arial, Helvetica, sans-serif">
            &nbsp;</p>
        <p style="font-size: medium; font-family: Arial, Helvetica, sans-serif">
            <asp:Button ID="goButton" runat="server" OnClick="goButton_Click" Text="GO" />
        </p>
        <p style="font-size: medium; font-family: Arial, Helvetica, sans-serif">
            &nbsp;</p>
        <p style="font-size: medium; font-family: Arial, Helvetica, sans-serif">
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
