using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int simpleArraySum(int n, int[] ar) 
    {
        var sum = 0;
           
        for(var i = 0; i < n; i++)
        {
        sum += ar[i];
        }
       
        return sum;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = simpleArraySum(n, ar);
        Console.WriteLine(result);
    }
}
