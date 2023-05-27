using KpopZtation.Handler;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace KpopZtation.Controller
{
    public class CustomerController
    {

        public static String createCustomer(String name, String email, String gender, String address, String pass)
        {
            if (name.Equals("") || pass.Equals("") || email.Equals("") || gender.Equals("") || address.Equals(""))
            {
                return "Some credentials is missing !";
            }

            if (name.Length < 5 || name.Length > 50)
            {
                return "Name must be between 5 and 50 characters !";
            }

            if (!email.Contains("@") && !email.Contains("."))
            {
                return "Must contain @ and .";
            }
            else if (email.StartsWith("@") || email.EndsWith("@"))
            {
                return "@ cannot be the first/last letter";
            }
            else if (email.StartsWith(".") || email.EndsWith("."))
            {
                return ". cannot be the first/last letter";
            }
            else if (email.Contains("@.") || email.Contains(".@"))
            {
                return "@ and . cannot be side by side";
            }

            if (CustomerHandler.isEmailUnique(email).Equals(true))
            {
                return "This email already used. Try with different email !";
            }

            if (!address.EndsWith("Street"))
            {
                return "Address must ends with 'Street' !";
            }

            if (ValidateAlphanumeric(pass) == false)
            {
                return "Password must alphanumeric !";
            }

            String role = "User";

            CustomerHandler.createCustomer(name, email, gender, address, pass, role);
            return "Register Successful";
        }

        public static bool ValidateAlphanumeric(String pass)
        {
            Regex regex = new Regex("(?=.*[a-zA-Z])(?=.*[0-9])");
            return regex.IsMatch(pass);
        }

        public static String loginStatus(String email, String pass)
        {
            String user_email = CustomerHandler.getData(email, pass).CustomerEmail;
            String user_pass = CustomerHandler.getData(email, pass).CustomerPassword;

            if(!email.Equals(user_email) || !pass.Equals(user_pass))
            {
                return "Email or Password is incorrect !";
            }

            return "Login Successfuly";
        }

        public static Customer getData(String email, String pass)
        {
            return CustomerHandler.getData(email, pass);
        }
    }
}