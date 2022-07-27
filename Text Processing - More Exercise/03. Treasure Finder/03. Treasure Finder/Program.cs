using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            StringBuilder output = new StringBuilder();

            string input = Console.ReadLine();
            while (input != "find")
            {
                string decryptedMessage = DecryptMessage(input, keys);

                string treasureType = FindTreasure(decryptedMessage);
                string coordinates = FindCoordinates(decryptedMessage);

                output.AppendLine($"Found {treasureType} at {coordinates}");

                input = Console.ReadLine();
            }

            Console.WriteLine(output.ToString());
        }

        private static string FindCoordinates(string decryptedMessage)
        {
            string currMessage = decryptedMessage;

            int startIndex = currMessage.IndexOf('<');
            int endIndex = currMessage.IndexOf('>');

            string result = currMessage.Substring(startIndex + 1, endIndex - startIndex - 1);

            return result;
        }

        private static string FindTreasure(string decryptedMessage)
        {
            string currMessage = decryptedMessage;

            int startIndex = currMessage.IndexOf('&');
            currMessage = currMessage.Remove(startIndex, 1);

            int endIndex = currMessage.IndexOf('&');

            string result = currMessage.Substring(startIndex, endIndex - startIndex);

            return result;
        }

        private static string DecryptMessage(string input, int[] keys)
        {
            StringBuilder result = new StringBuilder();

            if (input.Length > keys.Length)
            {
                int counter = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    char resultChar = Convert.ToChar(input[i] - keys[counter]);
                    result.Append(resultChar);

                    if (counter == keys.Length - 1)
                    {
                        counter = 0;
                    }
                    else
                    {
                        counter++;
                    }
                }
            }
            else
            {
                int counter = keys.Length - 1;
                for (int i = 0; i < input.Length; i++)
                {
                    char resultChar = Convert.ToChar(input[i] - keys[counter]);
                    result.Append(resultChar);

                    counter--;
                }
            }
            return result.ToString();
        }
    }
}
