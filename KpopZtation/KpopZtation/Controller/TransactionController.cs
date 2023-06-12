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