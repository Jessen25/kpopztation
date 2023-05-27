using KpopZtation.Controller;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class ArtistDetail : System.Web.UI.Page
    {
        protected static bool isAdmin = false;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["user"];

                if (cookie != null)
                {
                    String role = cookie["Role"].ToString();

                    if(role == "Admin")
                    {
                        isAdmin = true;
                        insertAlbumButton.Visible = true;
                    } 
                }
            
                String artistId = Request["ArtistId"];
                Artist artist = ArtistController.getArtist(artistId);

                artistIDLabel.Text += artistId;
                artistNameLabel.Text += artist.ArtistName;
                artistImage.ImageUrl = artist.ArtistImage;

                artistIDLabel.Style["font-size"] = "16px";
                artistNameLabel.Style["font-size"] = "16px";

                AlbumsGridView.DataSource = AlbumController.getAllAlbums(artistId);
                AlbumsGridView.EmptyDataText = "No data";
                AlbumsGridView.DataBind();
            }
        }

        protected void insertAlbumButton_Click(object sender, EventArgs e)
        {
            String artistId = Request["ArtistId"];
            Response.Redirect("~/View/InsertAlbum.aspx?ArtistId=" + artistId);
        }

        protected void AlbumsGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = AlbumsGridView.Rows[e.RowIndex];
            String albumId = row.Cells[0].Text;

            Response.Redirect("~/View/UpdateAlbum.aspx?AlbumId=" + albumId);
        }

        protected void AlbumsGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = AlbumsGridView.Rows[e.RowIndex];
            String albumId = row.Cells[0].Text;
            String artistId = row.Cells[1].Text;

            AlbumController.deleteAlbum(albumId);
            Response.Redirect("~/View/ArtistDetail.aspx?ArtistId=" + artistId);
        }
    }
}