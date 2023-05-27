<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="KpopZtation.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Home Page</h1>

    <div id="user_page" runat="server">
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="ArtistId" DataSourceID="SqlDataSource2" OnSelectedIndexChanging="GridView_SelectedIndexChanging">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ArtistId" HeaderText="ArtistId" InsertVisible="False" ReadOnly="True" SortExpression="ArtistId" />
                <asp:BoundField DataField="ArtistName" HeaderText="ArtistName" SortExpression="ArtistName" />
                <asp:ImageField HeaderText="ArtistImage" DataImageUrlField="ArtistImage" ControlStyle-Height="120" ControlStyle-Width="140" />
                <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Select" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Artist]"></asp:SqlDataSource>
    </div>

    <div id="admin_page" runat="server" visible="false">
        <asp:GridView ID="GridViewAdmin" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="ArtistId" DataSourceID="SqlDataSource2" OnRowUpdating="GridViewAdmin_RowUpdating" OnRowDeleting="GridViewAdmin_RowDeleting" OnSelectedIndexChanging="GridView_SelectedIndexChanging">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ArtistId" HeaderText="ArtistId" InsertVisible="False" ReadOnly="True" SortExpression="ArtistId" />
                <asp:BoundField DataField="ArtistName" HeaderText="ArtistName" SortExpression="ArtistName" />
                <asp:ImageField HeaderText="ArtistImage" DataImageUrlField="ArtistImage" ControlStyle-Height="120" ControlStyle-Width="140" >
                <ControlStyle Height="120px" Width="140px"></ControlStyle>
                </asp:ImageField>
                <asp:ButtonField ButtonType="Button" CommandName="Update" Text="Update" />
                <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
                <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Select" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Artist]"></asp:SqlDataSource>
        <asp:Button ID="insertButton" runat="server" Text="Insert" OnClick="insertButton_Click" />
    </div>

</asp:Content>