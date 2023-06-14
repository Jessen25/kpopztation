using KpopZtation.Handler;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        public static List<TransactionDetail> getTransactionById(String transactionId)
        {
            return TransactionHandler.getTransactionById(transactionId);
        }

        public static Customer getCustomerId(String email)
        {
            return TransactionHandler.getCustomerId(email);
        }

    }
}