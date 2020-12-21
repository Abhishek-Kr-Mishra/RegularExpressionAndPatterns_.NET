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

            if (patternsMatching.ValidateFirstName()) { Console.WriteLine("Correct Last Name Format"); }
            else { Console.WriteLine("Last Name format is wrong"); }
        }
    }
}
