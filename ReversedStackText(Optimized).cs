using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string ReverseText(string input2)
            {
                char[] charArray = input2.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }

            
            var stack = new Stack<string>();
            var input = Console.ReadLine();

            stack.Push(input);
            Console.WriteLine(ReverseText(stack.Pop()));

        }
    }
}
