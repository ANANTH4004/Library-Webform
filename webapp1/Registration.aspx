<%@ Page Title="" Language="C#" MasterPageFile="~/Library.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="webapp1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>    
            .LabelGrey     
            {    
                font-weight: bold;    
                color: blue;    
            }    
                
            .LabelBlue     
            {    
                font-weight: bold;    
                color: darkblue;    
            }    
                
            .ClassJoined     
            {    
                font-weight: normal;    
                font-size: 50px;    
                color: darkcyan;    
            }    
        </style>   
    <asp:Label ID="Label2"  CssClass="LabelBlue " runat="server" Text="User ID : "></asp:Label>
<asp:TextBox ID="TextBox1" runat="server" TextMode="Email" ToolTip="Enter your Mail Id."></asp:TextBox>
<br />
<br />
<asp:Label ID="Label3" CssClass="LabelBlue "  runat="server" Text="Password : "></asp:Label>
<asp:TextBox ID="TextBox2" runat="server" ToolTip="Enter Password"></asp:TextBox>
<br />
<br />
<asp:Button ID="Button1" runat="server" Height="59px" OnClick="Button1_Click" Text="Sign Up" Width="157px" />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server"></asp:Label>
<br />
<br />
</asp:Content>
