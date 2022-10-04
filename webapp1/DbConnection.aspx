<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DbConnection.aspx.cs" Inherits="webapp1.DbConnection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-size: large; font-weight: bold; font-family: 'Cascadia Code'">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Search Product Using Product ID:<br />
            <br />
            <asp:Label ID="ProdId" runat="server" Text="Enter Product Id : "></asp:Label>
            <asp:TextBox ID="txtProdId" runat="server" Height="40px" TextMode="Number" Width="188px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnProdId" runat="server" ForeColor="Black" Height="43px" OnClick="btnProdId_Click" Text="Submit" Width="110px" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
