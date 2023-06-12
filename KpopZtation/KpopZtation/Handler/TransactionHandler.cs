using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class TransactionHandler
    {

        public static List<TransactionDetail> getTransactionById(String transactionId)
        {
            return TransactionRepository.getTransactionById(transactionId);
        }

        public static Customer getCustomerId(String email)
        {
            return TransactionRepository.getCustomerId(email);
        }

    }
}