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

            string firstNameOutput = patternsMatching.ValidateFirstNameByUsingLambda("Abhishek");
            Console.WriteLine(firstNameOutput);

            string lastNameOutput = patternsMatching.ValidateLastNameByUsingLambda("Mishra");
            Console.WriteLine(lastNameOutput);

            string emailIdOutput = patternsMatching.ValidateEmailByUsingLambda("abh224272@gmail.com");
            Console.WriteLine(emailIdOutput);

            string passwordOutput = patternsMatching.ValidatePasswordByUsingLambda("abhhishekMishra@123");
            Console.WriteLine(passwordOutput);

            string phoneNumberOutput = patternsMatching.ValidatePhoneNumberByUsingLambda("+917559171697");
            Console.WriteLine(phoneNumberOutput);

            patternsMatching.ValidAndInvalidEmailID();
        }
    }
}
