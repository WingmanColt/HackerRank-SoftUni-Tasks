using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
static void Main(string[] args)
{

        var text = Console.ReadLine();
        var pattern = Console.ReadLine();

        var count = 0;
        var index = -1;

        while(true)
        {
            index = text.IndexOf(pattern, index + 1);

            if (index == -1)
                break;

            count++;

        }
        Console.WriteLine(count);

    }
}
    

