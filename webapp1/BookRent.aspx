<%@ Page Title="" Language="C#" MasterPageFile="~/Library.Master" AutoEventWireup="true" CodeBehind="BookRent.aspx.cs" Inherits="webapp1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Book_No" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Book_No" HeaderText="Book_No" ReadOnly="True" SortExpression="Book_No" />
            <asp:BoundField DataField="Book_Name" HeaderText="Book_Name" SortExpression="Book_Name" />
            <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
            <asp:BoundField DataField="Cost" HeaderText="Cost" SortExpression="Cost" />
            <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:LoginCnStr %>" SelectCommand="SELECT * FROM [Book]"></asp:SqlDataSource>
    <br />
&nbsp;&nbsp;
    <br /><asp:Label ID="Label2" runat="server" Text="Select Book :  "></asp:Label>&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Book_Name" DataValueField="Book_No">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Borrow" />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Books Details"></asp:Label>
&nbsp;: 
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
        <Columns>
            <asp:BoundField DataField="Book_Name" HeaderText="Book_Name" SortExpression="Book_Name" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:LoginCnStr %>" SelectCommand="sp_GetBooks" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:SessionParameter Name="p_UserId" SessionField="UserId" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
