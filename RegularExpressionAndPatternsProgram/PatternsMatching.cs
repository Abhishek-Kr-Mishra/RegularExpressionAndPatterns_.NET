using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressionAndPatternsProgram
{
    class PatternsMatching
    {
        public static string REGEX_firstName = "^[A-Z][a-zA-Z]{2,}";

        public bool ValidateFirstName()
        {
            Console.WriteLine("Enter the First Name");
            string fname = Console.ReadLine(); ;
            return Regex.IsMatch(fname, REGEX_firstName);
        }
    }
}
