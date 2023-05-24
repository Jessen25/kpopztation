using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user"];
            if(cookie != null)
            {
                String role = cookie["Role"].ToString();

                if (role.Equals("Admin"))
                {
                    user_page.Visible = false;
                } else if (role.Equals("User"))
                {
                    admin_page.Visible = false;
                }
            }
        }

        protected void insertButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertArtist.aspx");
        }

        protected void GridViewAdmin_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridViewAdmin.Rows[e.RowIndex];
            String id = row.Cells[0].Text;

            Response.Redirect("UpdateArtist.aspx?id=" + id);
        }

        protected void GridViewAdmin_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridViewAdmin.Rows[e.RowIndex];
            String id = row.Cells[0].Text;

            ArtistController.deleteArtist(id);
            Response.Redirect("HomePage.aspx");
        }
    }
}