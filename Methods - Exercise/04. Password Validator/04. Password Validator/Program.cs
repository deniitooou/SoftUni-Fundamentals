using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isPasswordLengthValid = ValidatePasswordLength(password);
            bool isPasswordContainsValidSymbols = ValidatePasswordText(password);
            bool isDigitInPasswordLeastTwo = ValidatePasswordDigit(password);

            if (!isPasswordLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isPasswordContainsValidSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isDigitInPasswordLeastTwo)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isDigitInPasswordLeastTwo && isPasswordContainsValidSymbols && isPasswordLengthValid)
            {
                Console.WriteLine($"Password is valid");
            }
        }

        private static bool ValidatePasswordDigit(string password)
        {
            int count = 0;
            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }
            return count >= 2;
        }

        private static bool ValidatePasswordText(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool ValidatePasswordLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
    }
