using System;
using System.Collections.Generic;

namespace _202HappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 202");
            Console.WriteLine(IsHappy(19));
            Console.WriteLine(IsHappy(2));
            Console.WriteLine(IsHappy(999));
            Console.ReadKey();
        }

        // https://leetcode.com/problems/happy-number/
        // 202. Happy Number
        // Write an algorithm to determine if a number n is happy.
        // A happy number is a number defined by the following process:
        // Starting with any positive integer, replace the number by the sum of the squares of its digits.
        // Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        // Those numbers for which this process ends in 1 are happy.
        // Return true if n is a happy number, and false if not.

        static public bool IsHappy(int n)
        {
            Console.WriteLine($"n = {n}");
            List<int> used = new List<int>();
            int num = n;
            while (num != 1 && !used.Contains(num)) {
                used.Add(num);
                string s = num.ToString();
                num = 0;
                for (int i=0; i < s.Length; i++)
                {
                    num += (int)Math.Pow(int.Parse(s[i].ToString()), 2);
                    Console.Write($" {s[i]} > {num}; ");
                }
                Console.WriteLine($" = {num}");
            }
            return num == 1;
        }
    }
}
