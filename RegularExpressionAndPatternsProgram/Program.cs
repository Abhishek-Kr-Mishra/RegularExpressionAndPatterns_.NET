using System;
using System.Text.RegularExpressions;

namespace RegularExpressionAndPatternsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Regex And Pattern Matching");
            PatternsMatching patternsMatching = new PatternsMatching();

            if (patternsMatching.ValidateFirstName("Abhishek")){ Console.WriteLine("Valid First Name"); }
            else { Console.WriteLine("Invalid First Name"); }

            if (patternsMatching.ValidateLastName("Mishra")) { Console.WriteLine("Valid Last Name"); }
            else { Console.WriteLine("Invalid Last Name"); }

            if (patternsMatching.ValidateEmail("abh224272@gmail.com")) { Console.WriteLine("Valid Email ID"); }
            else { Console.WriteLine("Invalid Email ID"); }

            if (patternsMatching.ValidatePhoneNumber("+917559171697")) { Console.WriteLine("Valid Phone Number"); }
            else { Console.WriteLine("Invalid Phone Number"); }

            if (patternsMatching.ValidatePassword("abhhishekMishra@321")) { Console.WriteLine("Valid Password"); }
            else { Console.WriteLine("Invalid Password"); }

            patternsMatching.ValidAndInvalidEmailID();
        }
    }
}
