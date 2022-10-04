<%@ Page Title="" Language="C#" MasterPageFile="~/Library.Master" AutoEventWireup="true" CodeBehind="LibraryLogin.aspx.cs" Inherits="webapp1.LibraryLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label2" runat="server" Text="User ID : "></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    Password :
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Height="39px" OnClick="Button1_Click" Text="Login" Width="134px" />
    <br />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server"></asp:Label>
    <br />
</asp:Content>
