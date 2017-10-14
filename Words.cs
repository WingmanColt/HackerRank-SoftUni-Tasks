using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
class Program
{
    static void Main(string[] args)
    {
            var input = "Java C# PHP PHP JAVA C java";
            var words = input.ToLower().Split(' ');
            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                counts[word] = 0 ;
            }
            foreach (var word in words)
            {
                counts[word]++;
            }

            Console.WriteLine(String.Join(", ", counts));
        }
}
}
