using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char symbol = username[i];
                password += symbol;
            }

            for (int i = 0; i < 4; i++)
            {
                string currentPassword = Console.ReadLine();

                if (currentPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (password != currentPassword && i >= 0 && i < 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else if (password != currentPassword && i == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                }
            }
        }
    }
}
