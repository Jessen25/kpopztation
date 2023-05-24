<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateArtist.aspx.cs" Inherits="KpopZtation.View.UpdateArtist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ArtistId" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ArtistId" HeaderText="ArtistId" InsertVisible="False" ReadOnly="True" SortExpression="ArtistId" />
                <asp:BoundField DataField="ArtistName" HeaderText="ArtistName" SortExpression="ArtistName" />
                <asp:ImageField HeaderText="ArtistImage" DataImageUrlField="ArtistImage" ControlStyle-Height="120" ControlStyle-Width="140" />
            </Columns>
        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Artist] WHERE ArtistId = @id">
            <SelectParameters>
                <asp:QueryStringParameter Name="id" QueryStringField="id" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        
        <br />
        <asp:Label ID="Label1" runat="server" Text="Artist Name"></asp:Label> <br />
        <asp:TextBox ID="artistNameBox" runat="server"></asp:TextBox> <br /><br />

        <asp:Label ID="Label2" runat="server" Text="Image"></asp:Label><br />
        <asp:FileUpload ID="imageUpload" runat="server" /><br /><br />

        <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" /><br />
        <asp:Label ID="warningLabel" runat="server" Text=""></asp:Label>

    </form>
</body>
</html>
