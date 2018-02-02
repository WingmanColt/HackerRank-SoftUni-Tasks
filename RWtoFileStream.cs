using System;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var Rstream = new StreamReader("Program.cs"))
            {
                using (var Wstream = new StreamWriter("reserved.txt"))
                {
                    string line;
                    while ((line = Rstream.ReadLine()) != null)
                    {

                        for (int counter = line.Length - 1; counter >= 0; counter--)
                        {
                            Wstream.Write(line[counter]);
                        }
                        Wstream.WriteLine();
                    }
                }
            }
        }
    }
}