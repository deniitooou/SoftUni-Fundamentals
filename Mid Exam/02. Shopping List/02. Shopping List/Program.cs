using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(new string[] { "!" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Urgent":
                        Urgent(list, command[1]);
                        break;
                    case "Unnecessary":
                        Unnecessary(list, command[1]);
                        break;
                    case "Correct":
                        Correct(list, command[1], command[2]);
                        break;
                    case "Rearrange":
                        Rearrange(list, command[1]);
                        break;
                }
            }
                Console.WriteLine(string.Join(", ", list));

            static void Urgent(List<string> list, string item)
            {
                if (!list.Contains(item))
                {
                    list.Insert(0, item);
                }
            }

            static void Unnecessary(List<string> list, string item)
            {
                list.Remove(item);
            }

            static void Correct(List<string> list, string oldItem, string newItem)
            {
                if (!list.Contains(oldItem))
                {
                    return;
                }

                int index = list.IndexOf(oldItem);
                list.RemoveAt(index);
                list.Insert(index, newItem);
            }

            static void Rearrange(List<string> list, string item)
            {
                if (!list.Contains(item))
                {
                    return;
                }
                list.Remove(item);
                list.Add(item);
            }
        }
    }
}
