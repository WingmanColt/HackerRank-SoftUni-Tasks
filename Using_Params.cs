using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 3, 4, 5));
            Console.WriteLine(Add(2.5, 3.3, 4.7, 5.5));
        }

        public static int Add(params int[] nums)
        {
            return nums.Sum();
        }

      public static double Add(params double[] nums)
        {
            return nums.Sum();
        }
    }
}
