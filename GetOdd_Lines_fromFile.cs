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


       string[] lines = File.ReadAllLines("input.txt");
        string[] oddlines = lines.Where((line, i) => i % 2 == 1).ToArray();

        File.WriteAllLines("output.txt", oddlines);

    }

}
    

