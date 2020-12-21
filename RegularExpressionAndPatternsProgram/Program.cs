using System;

namespace RegularExpressionAndPatternsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Regex And Pattern Matching");
            PatternsMatching patternsMatching = new PatternsMatching();

            if (patternsMatching.ValidateFirstName()){ Console.WriteLine("Correct First Name Format"); }
            else { Console.WriteLine("First Name format is wrong"); }

            if (patternsMatching.ValidateLastName()) { Console.WriteLine("Correct Last Name Format"); }
            else { Console.WriteLine("Last Name format is wrong"); }

            if (patternsMatching.ValidateEmail()) { Console.WriteLine("Correct Email Format"); }
            else { Console.WriteLine("Email format is wrong"); }

            if (patternsMatching.ValidatePhoneNumber()) { Console.WriteLine("Correct Phone Number Format"); }
            else { Console.WriteLine("Phone Number format is wrong"); }

            if (patternsMatching.ValidatePassword()) { Console.WriteLine("Correct Password Format"); }
            else { Console.WriteLine("Password format is wrong"); }
        }
    }
}
