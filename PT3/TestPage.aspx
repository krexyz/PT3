<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="PT3.TestPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
</p>
<p>
</p>
<p>
    Answer :
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnAnswer" runat="server" OnClick="Button1_Click" Text="Submit Answer" />
</p>

</asp:Content>
