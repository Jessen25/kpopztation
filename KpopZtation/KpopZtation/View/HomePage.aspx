<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="KpopZtation.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Home Page</h1>

    <div id="admin_page" runat="server">
        <asp:GridView ID="GridViewAdmin" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="ArtistId" DataSourceID="SqlDataSource2" OnRowUpdating="GridViewAdmin_RowUpdating" OnRowDeleting="GridViewAdmin_RowDeleting">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ArtistId" HeaderText="ArtistId" InsertVisible="False" ReadOnly="True" SortExpression="ArtistId" />
                <asp:BoundField DataField="ArtistName" HeaderText="ArtistName" SortExpression="ArtistName" />
                <asp:ImageField HeaderText="ArtistImage" DataImageUrlField="ArtistImage" ControlStyle-Height="120" ControlStyle-Width="140" />
                <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button runat="server" Text="Update" 
                            Visible='<%# isAdmin %>' 
                            CommandName="Update"/>
                            <asp:Button runat="server" Text="Delete" 
                            Visible='<%# isAdmin %>' 
                            CommandName="Delete"/>
                        </ItemTemplate> 
                    </asp:TemplateField>
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
        <asp:Button ID="insertButton" runat="server" Text="Insert" OnClick="insertButton_Click"/>
    </div>

</asp:Content>