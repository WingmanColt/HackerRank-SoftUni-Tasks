using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialization an array with values from console
            // Example input: 3, 6
            int[] RowsColumns = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();

            // Initialization an array(Matrix with one dimensional 'int[,]')
            int[,] matrix = new int[RowsColumns[0], RowsColumns[1]];

            // Cycle for Rows  
            for (int Rows = 0; Rows < RowsColumns[0]; Rows++)
            {
                // Input row values
             var rowValues = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();
             
                // Cycle for Columns
                for (int Columns = 0; Columns < RowsColumns[1]; Columns++)
                {
                    // Adding values to matrix 
                    matrix[Rows, Columns] = rowValues[Columns];
                }

            }

            int sum = 0;

            // Getting rows lenght 
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                // Getting columns lenght
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {

                    // Sum rows and columns
                    sum += matrix[rows, columns];
        
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}

        }
    }
}

// Check the code
/*

- Input Example:

3, 6
7, 1, 3, 3, 2, 1
1, 3, 9, 8, 5, 6
4, 6, 7, 9, 1, 0

- Output:
9 8
7 9
33

*/

