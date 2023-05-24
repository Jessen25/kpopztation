using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class CustomerRepository
    {
        public static ModelKpopZtationEntities db = Connect.getInstances();

        public static void createCustomer(Customer data)
        {
            db.Customers.Add(data);
            db.SaveChanges();
        }
       
        public static Boolean isEmailUnique(String email)
        {
            return db.Customers.Any(x => x.CustomerEmail.Equals(email));
        }

        public static Customer getData(String email, String pass)
        {
            return db.Customers.Where(x => x.CustomerEmail.Equals(email) && x.CustomerPassword.Equals(pass)).FirstOrDefault();
        }
    }
}