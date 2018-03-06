using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int>()
            {
                2, 3, 4,
                3 ,3, 3,
                5, 5, 5
            };

           // nums.Add("2");
           // nums.Add("3");

            printNums(nums);
        }
        public static void printNums(List<int> nums)
        {
            foreach (var number in nums)
            {
                Console.WriteLine(number);
            }
        }
    }
}
