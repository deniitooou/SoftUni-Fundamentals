using System;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] passwords = Console.ReadLine().Split(", ");

            foreach (var password in passwords)
            {
                if (password.Length > 3 && password.Length < 16)
                {
                    bool isValid = true;
                    foreach (char ch in password)
                    {
                        if (!char.IsLetterOrDigit(ch)
                            && ch != '-'
                            && ch != '_')
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(password);
                    }
                }
            }
        }
    }
}
