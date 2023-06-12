using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Handler;
using KpopZtation.Model;

namespace KpopZtation.Controller
{
    public class TransactionController
    {
        public static String createHeader(int CustomerID)
        {
            return TransactionHandler.createHeader(CustomerID);
        }

        public static void createDetails(int TransactionID, List<Cart> cart)
        {
            TransactionHandler.createDetails(TransactionID, cart);
        }

    }
}