<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="webapp1.welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="Personal">Welcome!!!!<br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="64px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="162px">
                <asp:ListItem>Personal</asp:ListItem>
                <asp:ListItem>Banking</asp:ListItem>
                <asp:ListItem>Educational</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:MultiView ID="MultiView" runat="server">
                <asp:View ID="PersonalDetails" runat="server">
                   Enter FirstName :
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Enter LastName :<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Upload File :<asp:FileUpload ID="FileUpload1" runat="server" />
                </asp:View>
                <asp:View ID="BankingDetails" runat="server">
                </asp:View>
                <asp:View ID="EducationalDetails" runat="server">
                </asp:View>
            </asp:MultiView>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
