using KpopZtation.Controller;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class ArtistDetail : System.Web.UI.Page
    {
        protected bool isAdmin = false;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["user"];

                if (cookie != null)
                {
                    String role = cookie["Role"].ToString();

                    if (role == "Admin")
                    {
                        isAdmin = true;
                        insertAlbumButton.Visible = true;
                    }
                }

                String artistId = Request["ArtistId"];
                Artist artist = ArtistController.getArtist(artistId);

                artistNameLabel.Text = artist.ArtistName;
                artistImage.ImageUrl = artist.ArtistImage;

                artistNameLabel.Style["font-size"] = "24px";
                artistNameLabel.Style["font-weight"] = "bold";

                albumRepeater.DataSource = AlbumController.getAllAlbums(artistId);
                albumRepeater.DataBind();
            }
        }

        protected void insertAlbumButton_Click(object sender, EventArgs e)
        {
            String artistId = Request["ArtistId"];
            Response.Redirect("~/View/InsertAlbum.aspx?ArtistId=" + artistId);
        }

        protected void updateButton_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("~/View/UpdateAlbum.aspx?AlbumId=" + e.CommandArgument.ToString());
        }

        protected void deleteButton_Command(object sender, CommandEventArgs e)
        {
            AlbumController.deleteAlbum(e.CommandArgument.ToString());
            Response.Redirect("~/View/ArtistDetail.aspx?ArtistId=" + Request["ArtistId"]);
        }

        protected void selectButton_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("~/View/AlbumDetail.aspx?AlbumId=" + e.CommandArgument.ToString());
        }

        //protected void AlbumsGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        //{
        //    GridViewRow row = AlbumsGridView.Rows[e.RowIndex];
        //    String albumId = row.Cells[0].Text;

        //    Response.Redirect("~/View/UpdateAlbum.aspx?AlbumId=" + albumId);
        //}

        //protected void AlbumsGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //    GridViewRow row = AlbumsGridView.Rows[e.RowIndex];
        //    String albumId = row.Cells[0].Text;
        //    String artistId = row.Cells[1].Text;

        //    AlbumController.deleteAlbum(albumId);
        //    Response.Redirect("~/View/ArtistDetail.aspx?ArtistId=" + artistId);
        //}
    }
}