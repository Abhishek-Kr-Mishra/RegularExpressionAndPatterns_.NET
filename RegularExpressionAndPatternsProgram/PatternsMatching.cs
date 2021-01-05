using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressionAndPatternsProgram
{
    public class PatternsMatching
    {
        public static string REGEX_firstName = "^[A-Z][a-zA-Z]{2,}";
        public static string REGEX_lastName = "^[A-Z][a-zA-Z]{2,}";
        public static string REGEX_EMAIL = @"^[A-Za-z0-9]+([.\-_][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]{2,4}([\.][a-zA-Z]{2}){0,1}$";
        public static string REGEX_PhoneNumber = "^[+]91[6-9]{1}[0-9]{9}$";
        public static string REGEX_PASSWORD = "^(?=.{8,}$)(?=.*?[0-9])(?=.*[A-Z])[a-zA-Z0-9]*[#!@$^&-][a-zA-Z0-9]*$";

        public bool ValidateFirstName(string fname)
        {
            bool matchValue =  Regex.IsMatch(fname, REGEX_firstName);
            if (matchValue == false)
            {
                throw new RegularExpressionCustomException(RegularExpressionCustomException.ExceptionType.INVALID_VALUE, "Invalid First Name");
            }
            else
            {
                return matchValue;
            }
        }
        public bool ValidateLastName(string lname)
        {
            bool matchValue = Regex.IsMatch(lname, REGEX_lastName);
            if (matchValue == false)
            {
                throw new RegularExpressionCustomException(RegularExpressionCustomException.ExceptionType.INVALID_VALUE, "Invalid Last Name");
            }
            else
            {
                return matchValue;
            }
        }
        public bool ValidateEmail(string email)
        {
            bool matchValue =  Regex.IsMatch(email, REGEX_EMAIL);
            if (matchValue == false)
            {
                throw new RegularExpressionCustomException(RegularExpressionCustomException.ExceptionType.INVALID_VALUE, "Invalid Email ID");
            }
            else
            {
                return matchValue;
            }
        }
        public bool ValidatePhoneNumber(string phoneNumber)
        {
            bool matchValue =  Regex.IsMatch(phoneNumber, REGEX_PhoneNumber);
            if (matchValue == false)
            {
                throw new RegularExpressionCustomException(RegularExpressionCustomException.ExceptionType.INVALID_VALUE, "Invalid Phone Number");
            }
            else
            {
                return matchValue;
            }
        }
        public bool ValidatePassword(string password)
        {
            bool matchValue = Regex.IsMatch(password, REGEX_PASSWORD);
            if (matchValue == false)
            {
                throw new RegularExpressionCustomException(RegularExpressionCustomException.ExceptionType.INVALID_VALUE, "Invalid Password");
            }
            else
            {
                return matchValue;
            }
        }

        public void ValidAndInvalidEmailID()
        {
            string[] validEmails = { "1.abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com",
            "abc-100@abc.net","abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc+100@gmail.com", "abc", 
                "abc@.com.my","abc123@gmail.a","abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com",
                "abc..2002@gmail.com", "abc.@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au"};
            for (int i = 0; i < validEmails.Length; i++)
            {
                if (Regex.IsMatch(validEmails[i], REGEX_EMAIL))
                {
                    Console.WriteLine(i+1 + "    "+ validEmails[i] + "  =>Valid Emaild Id");
                }
                else
                {
                    Console.WriteLine(i+1 + "  " + validEmails[i] + "  =>Invalid Email Id");
                }
            }
        }
    }
}
