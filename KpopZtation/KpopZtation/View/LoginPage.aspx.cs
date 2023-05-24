using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user"];
            if (cookie != null)
            {
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            String email = emailBox.Text;
            String pass = passwordBox.Text;
            Boolean remember = rememberMe.Checked;

            String warningText = CustomerController.loginStatus(email, pass);
            warningLabel.Text = warningText;

            String name = CustomerController.getName(email, pass);
            String role = CustomerController.getRole(email, pass);

            if (warningLabel.Text.Equals("Login Successfuly") && remember)
            {
                HttpCookie cookie = new HttpCookie("user");
                cookie["Name"] = name;
                cookie["Role"] = role;
                cookie.Expires.AddMonths(1);
                Response.Cookies.Add(cookie);
                Response.Redirect("HomePage.aspx");
            }
        }
    }
}