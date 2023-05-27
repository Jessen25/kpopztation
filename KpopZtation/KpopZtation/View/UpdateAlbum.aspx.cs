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
    public partial class UpdateAlbum : System.Web.UI.Page
    {
        private static String artistId;

        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("I AM HERE");
            if (!Page.IsPostBack)
            {
                String albumId = Request["AlbumId"];
                Album album = AlbumController.getAlbumById(albumId);

                albumNameBox.Text = album.AlbumName;
                albumDescriptionBox.Text = album.AlbumDescription;
                albumPriceBox.Text = album.AlbumPrice.ToString();
                albumStockBox.Text = album.AlbumStock.ToString();
                albumImage.ImageUrl = album.AlbumImage;
                artistId = album.ArtistId.ToString();
            }
        }

        protected void albumUpdateButton_Click(object sender, EventArgs e)
        {
            String albumId = Request["AlbumId"];
            String albumName = albumNameBox.Text;
            String albumDescription = albumDescriptionBox.Text;
            String albumPrice = albumPriceBox.Text;
            String albumStock = albumStockBox.Text;

            HttpPostedFile albumImage = albumImageUpload.PostedFile;

            String warningText = AlbumController.updateAlbum(artistId, albumId, albumName, albumDescription, albumPrice, albumStock, albumImage);
            warningLabel.Text = warningText;

            if (warningLabel.Text.Equals("Update Success!"))
            {
                Response.Redirect("~/View/ArtistDetail.aspx?ArtistId=" + artistId);
            }
        }
    }
}