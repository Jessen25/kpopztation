<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="KpopZtation.View.ArtistDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div>
        <h1>Artist Detail</h1>
         <h2>Artist Information</h2>
        <div style="display: flex; flex-direction: row;">
            <asp:Image ID="artistImage" runat="server" Width="100px" Height="100px"/><br>
            <div style="margin-left: 10px;" >
                <asp:Label ID="artistIDLabel" runat="server" Text="Artist Id: "></asp:Label><br>
                <asp:Label ID="artistNameLabel" runat="server" Text="Artist Name: "></asp:Label><br>
            </div>
        </div>

        <div>
            <h2>Artist Albums</h2>

            <asp:GridView ID="AlbumsGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowUpdating="AlbumsGridView_RowUpdating" OnRowDeleting="AlbumsGridView_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="AlbumId" HeaderText="AlbumId" SortExpression="AlbumId" />
                    <asp:BoundField DataField="ArtistId" HeaderText="ArtistId" SortExpression="ArtistId" />
                    <asp:BoundField DataField="AlbumName" HeaderText="AlbumName" SortExpression="AlbumName" />
                    <asp:ImageField HeaderText="AlbumImage" DataImageUrlField="AlbumImage" ControlStyle-Height="120" ControlStyle-Width="140" >
                    <ControlStyle Height="120px" Width="140px"></ControlStyle>
                    </asp:ImageField>
                    <asp:BoundField DataField="AlbumPrice" HeaderText="AlbumPrice" SortExpression="AlbumPrice" />
                    <asp:BoundField DataField="AlbumStock" HeaderText="AlbumStock" SortExpression="AlbumStock" />
                    <asp:BoundField DataField="AlbumDescription" HeaderText="AlbumDescription" SortExpression="AlbumDescription" />
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

        <asp:Button ID="insertAlbumButton" runat="server" Text="Insert Album" OnClick="insertAlbumButton_Click" />
        </div>
        
    </div>

    


</asp:Content>
