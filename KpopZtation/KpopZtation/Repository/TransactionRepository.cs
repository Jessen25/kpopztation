using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Model;

namespace KpopZtation.Repository
{
    public class TransactionRepository
    {
        public static ModelKpopZtationEntities db = Connect.getInstances();
        public static void createHeader(TransactionHeader header)
        {
            db.TransactionHeaders.Add(header);
            db.SaveChanges();
        }

        public static void createDetails(TransactionDetail details)
        {
            db.TransactionDetails.Add(details);
            db.SaveChanges();
        }

        public static TransactionDetail findDetailbyAlbumID(String TransactionId, String AlbumId)
        {
            int realId = int.Parse(TransactionId);
            int realId2 = int.Parse(AlbumId);
            return (from x in db.TransactionDetails where x.TransactionId == realId && x.AlbumId == realId2 select x).FirstOrDefault();
        }

    }
}