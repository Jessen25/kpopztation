using KpopZtation.Controller;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class TransactionPage : System.Web.UI.Page
    {
        public static List<TransactionHeader> transactions = new List<TransactionHeader>();

        protected void Page_Load(object sender, EventArgs e)
        {

            HttpCookie cookie = Request.Cookies["user"];
            String email = cookie["Email"].ToString();

            Customer customer = TransactionController.getCustomerId(email);
            transactions = TransactionRepository.GetTransactions(customer.CustomerId);

        }
    }
}