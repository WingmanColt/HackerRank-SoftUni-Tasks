using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxNumber;

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());


            if (c > GetMax(a, b)) MaxNumber = c;
            else MaxNumber = GetMax(a, b);

            Console.WriteLine(MaxNumber);
        }
        private static int GetMax(int a, int b)
        {
            int MAX;

            if (a > b) MAX = a;
            else MAX = b;

            return MAX;
        }
    }
}

