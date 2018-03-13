<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleDartsChallenge._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Button ID="dartsButton" runat="server" OnClick="dartsButton_Click" Text="Play Darts!" />
    <br />
    <br />
    <asp:Label ID="resultLabel" runat="server"></asp:Label>

</asp:Content>
