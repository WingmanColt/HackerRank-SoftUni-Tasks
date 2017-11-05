using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp64421424
{
    class Program
    {

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sk = int.Parse(Console.ReadLine());

            var namesweb = new List<string>();
            decimal totalLoss = 0;

            decimal selcol = 1;

            for (int i = 1; i < n; i++)
            {
                selcol *= sk;
            }

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();

                string name = input[0];
                long Visits1 = long.Parse(input[1]);
                decimal Visits2 = decimal.Parse(input[2]);

                namesweb.Add(name);
                totalLoss += Visits1 * Visits2;

            }
            
            Console.WriteLine(String.Join("\n", namesweb));
            Console.WriteLine("Total Loss: {0:F20}", totalLoss);
            Console.WriteLine("Security Token: {0}", selcol);
        }
    }
}
