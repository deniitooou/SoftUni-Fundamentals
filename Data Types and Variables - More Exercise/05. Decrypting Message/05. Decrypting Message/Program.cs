using System;

namespace _05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte decriptionKey = byte.Parse(Console.ReadLine());
            byte charactersCount = byte.Parse(Console.ReadLine());
            string message = "";

            while (charactersCount > 0)
            {
                message += ((char)(char.Parse(Console.ReadLine()) + decriptionKey)).ToString();

                charactersCount--;
            }

            Console.WriteLine(message);
        }
    }
}
