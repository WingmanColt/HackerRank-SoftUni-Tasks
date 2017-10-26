using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
class Program
{
    static void Main(string[] args)
    {

        var str = new StringBuilder();
        var num = decimal.Parse(Console.ReadLine());
            
        for (int i = 0; i < num; i++)
        {
            str.Append("Тест");
        }

        Console.WriteLine(str.ToString().Length);
    }
}
}
