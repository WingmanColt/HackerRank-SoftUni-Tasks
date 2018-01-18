using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void staircase(int n) 
    {
            for (short i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= n; ++j)
                {
                    if (j <= n - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
            
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        staircase(n);
    }
}
