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

            var input = Console.ReadLine();
            var stack = new Stack<char>();

            foreach (var characters in input)
            {
                stack.Push(characters);
            }

            
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop().ToString());
                
            }
            Console.ReadKey();
            

        }
    }
}



