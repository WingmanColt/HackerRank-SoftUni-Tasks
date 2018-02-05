
using System;
using static System.Console;

class Solution
{
    static void Main(String[] args)
    {
        var tokens_x1 = Console.ReadLine().Split(' ');
        var x1 = Convert.ToInt32(tokens_x1[0]);
        var v1 = Convert.ToInt32(tokens_x1[1]);
        var x2 = Convert.ToInt32(tokens_x1[2]);
        var v2 = Convert.ToInt32(tokens_x1[3]);
        var result = kangaroo(x1, v1, x2, v2);
        WriteLine(result);
    }

    static string kangaroo(int x1, int v1, int x2, int v2)
    {
        var sameLocationPossible = "";
        if (x1 < x2 && v1 < v2)
            sameLocationPossible = "NO";

        else if (x2 < x1 && v2 < v1)
            sameLocationPossible = "NO";

        else if (x2 < x1)
        {
            //v2 > v1
            var numberOfJumps = ((double)(x1 - x2)) / (v2 - v1);
            //check whether number of jumps is a whole number  i.e no fractional part.
            if (numberOfJumps % 1 == 0)
                sameLocationPossible = "YES";
            else
                sameLocationPossible = "NO";
        }
        else
        {
            //v1 > v2
            var numberOfJumps = ((double)(x2 - x1)) / (v1 - v2);
            //check whether number of jumps is a whole number  i.e no fractional part.
            if (numberOfJumps % 1 == 0)
                sameLocationPossible = "YES";
            else
                sameLocationPossible = "NO";
        }
        return sameLocationPossible;
    }
}