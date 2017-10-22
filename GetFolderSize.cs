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
    string[] files = Directory.GetFiles("../../TestFolder");
    double Sum = 0;

    foreach (string file in files)
    {
        FileInfo fileInfo = new FileInfo(file);
        Sum += fileInfo.Length;
    }

        Sum = Sum / 1024 / 1024; // byte to MB
        File.WriteAllText("../../result.txt", Sum.ToString());
}
}
    

