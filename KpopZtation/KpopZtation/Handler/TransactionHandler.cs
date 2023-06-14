using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Factory;
using KpopZtation.Model;
using KpopZtation.Repository;

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

        public static String createHeader(int CustomerID)
        {
            TransactionHeader header = TransactionFactory.createHeader(CustomerID);
            TransactionRepository.createHeader(header);

            return header.TransactionId.ToString();
        }

        public static void createDetails(int TransactionID, List<Cart> cart)
        {
            foreach (var x in cart)
            {
                TransactionDetail details = TransactionFactory.createDetails(TransactionID, x);
                TransactionRepository.createDetails(details);

                TransactionDetail SelectedTransaction = TransactionRepository.findDetailbyAlbumID(TransactionID.ToString(), x.AlbumId.ToString());
                Album SelectedAlbum = AlbumRepository.getAlbumById(x.AlbumId.ToString());
                AlbumRepository.updateStock(SelectedTransaction, SelectedAlbum);
            }
        }
    }
}