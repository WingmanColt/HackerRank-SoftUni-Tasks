using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            var carsPerGreenLight = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var carsQueue = new Queue<string>();

            while (input != "end")
            {
                var counter = Math.Min(carsQueue.Count, carsPerGreenLight);
                for (int i = 0; i < counter; i++)
                {
                    Console.WriteLine($"{carsQueue.Dequeue()} passed");
                }

                carsQueue.Enqueue(input);
                input = Console.ReadLine();
            }
        }
    }
}
