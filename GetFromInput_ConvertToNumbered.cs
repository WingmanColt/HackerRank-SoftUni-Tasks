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
       // Get text from input file (Първи ред, Втори ред...) convert to (1.Първи ред, 2.Втори ред...)

       string[] lines = File.ReadAllLines("input.txt");
        var numbers = lines.Select((line, index) => $"{index+1}. {line}");
        File.WriteAllLines("output.txt", numbers);
{}
    }
}
    

