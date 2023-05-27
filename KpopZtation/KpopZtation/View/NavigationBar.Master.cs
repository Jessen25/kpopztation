using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class NavigationBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["user"];
                if(cookie != null)
                {
                    String role = cookie["Role"].ToString();

                    if (role.Equals("Admin"))
                    {
                        cartButton.Visible = false;
                    }
                }
            }

        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void cartButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(""); // insert nama cart page
        }

        protected void transactionButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(""); // insert nama transaction page
        }

        protected void updateProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/UpdateProfile.aspx");
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user"];
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Set(cookie);
            Response.Redirect("~/View/LoginPage.aspx");
        }
    }
}