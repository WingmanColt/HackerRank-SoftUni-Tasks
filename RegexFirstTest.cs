using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
class Program
{
    static void Main(string[] args)
    {
        var text = @"https://www.cms-bg.eu/youtube 
                    drugtext test
                    http://www.shop.cms-bg.eu/";
        var pattern = @"(\w+)\:\/\/([a-z0-9._-]+)(.*)";

        foreach(Match match in Regex.Matches(text, pattern))
        {
            Console.WriteLine("Protocol: " + match.Groups[1]);
            Console.WriteLine("Host: " + match.Groups[2]);
            Console.WriteLine("Resources: " + match.Groups[3]);
        }


    }
}
}
