using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            var rhombusSize = int.Parse(Console.ReadLine());

            for (int rowSize = 0; rowSize <= rhombusSize; rowSize++)
            {
                PrintRow(rhombusSize, rowSize);
            }


            for (int rowSize = rhombusSize -1; rowSize > 0; rowSize--)
            {
                PrintRow(rhombusSize, rowSize);
            }

        }

       static void PrintRow(int rhombusSize, int rowSize)
        {
            for (int counter = 0; counter < rhombusSize - rowSize; counter++)
            {
                Console.Write(" ");
            }

            for (int counter = 0; counter < rowSize; counter++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
