﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new String[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            double average = nums.Average();
            nums.Sort();
            nums.Reverse();

            if (nums.Count > 5)
            {
                nums.RemoveRange(5, nums.Count - 5);
            }

            if (!nums.Any(x => x > average))
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(String.Join(" ", nums.Where(x => x > average)));
            }
        }
    }
}
