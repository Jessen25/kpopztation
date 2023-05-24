using KpopZtation.Factory;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class CustomerHandler
    {

        public static void createCustomer(String name, String email, String gender, String address, String pass, String role)
        {
            Customer cust = CustomerFactory.createCustomer(name, email, gender, address, pass, role);
            CustomerRepository.createCustomer(cust);
        }

        public static Boolean isEmailUnique(String email)
        {
            return CustomerRepository.isEmailUnique(email);
        }

        public static Customer getData(String email, String pass)
        {
            return CustomerRepository.getData(email, pass);
        }
    }
}