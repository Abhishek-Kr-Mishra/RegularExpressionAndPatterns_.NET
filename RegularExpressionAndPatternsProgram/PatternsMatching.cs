using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressionAndPatternsProgram
{
    class PatternsMatching
    {
        public static string REGEX_firstName = "^[A-Z][a-zA-Z]{2,}";
        public static string REGEX_lastName = "^[A-Z][a-zA-Z]{2,}";
        public static string REGEX_EMAIL = @"^[A-Za-z0-9]+([.\-_+][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]{2,4}([\.][a-zA-Z]{2})*$";
        public static string REGEX_PhoneNumber = "^[+]91[6-9]{1}[0-9]{9}$";
        public static string REGEX_PASSWORD = "^(?=.{8,}$)(?=.*?[0-9])(?=.*[A-Z])[a-zA-Z0-9]*[#!@$^&-][a-zA-Z0-9]*$";

        public bool ValidateFirstName()
        {
            Console.WriteLine("Enter the First Name");
            string fname = Console.ReadLine(); ;
            return Regex.IsMatch(fname, REGEX_firstName);
        }
        public bool ValidateLastName()
        {
            Console.WriteLine("Enter the Last Name");
            string lname = Console.ReadLine(); ;
            return Regex.IsMatch(lname, REGEX_lastName);
        }
        public bool ValidateEmail()
        {
            Console.WriteLine("Enter the Email ID");
            string email = Console.ReadLine(); ;
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public bool ValidatePhoneNumber()
        {
            Console.WriteLine("Enter the Phone Number with +91");
            string phoneNumber = Console.ReadLine(); ;
            return Regex.IsMatch(phoneNumber, REGEX_PhoneNumber);
        }
        public bool ValidatePassword()
        {
            Console.WriteLine("Enter the Password");
            string password = Console.ReadLine(); ;
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
