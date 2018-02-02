using System;
using System.Linq;

namespace ConsoleApp4
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

            // Declaration variables 
            int sum = 0;
            int rowIndex = 0, columnsIndex = 0;

            // Getting rows lenght 
            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                // Getting columns lenght
                for (int columns = 0; columns < matrix.GetLength(1) - 1; columns++)
                {
                    // declaration a temporary sum, get numbers as squere
                    /* example: 
                       9 8
                       7 9  */

                    var tempSum = matrix[rows, columns] + matrix[rows, columns + 1]
                        + matrix[rows + 1, columns] + matrix[rows + 1, columns + 1];

                    // check if temporary sum is biggest than sum. Assigns tempSum to Sum.
                    if (tempSum > sum)
                    {
                        sum = tempSum;

                        // Assigns index for print
                        rowIndex = rows;
                        columnsIndex = columns;
                    }


                }
            }
            // Print index, as squere 
            Console.WriteLine(matrix[rowIndex, columnsIndex] + " " + matrix[rowIndex, columnsIndex + 1]);
            Console.WriteLine(matrix[rowIndex + 1, columnsIndex] + " " + matrix[rowIndex + 1, columnsIndex + 1]);

            // print sum
            Console.WriteLine(sum);
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

