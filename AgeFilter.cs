using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleCount = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>();

            for (int i = 0; i < peopleCount; i++)
            {
                var nameAndAge = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                people.Add(nameAndAge[0], int.Parse(nameAndAge[1]));
            }
            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            var filter = CreateFilter(condition, age);
            var printer = CreatePrinter(format);
        }

        static Func<int, bool> CreateFilter(string condition, int age)
        {
            if (condition == "younger")
                return x => x < age;
            else
                return x => x >= age;

        }

        static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {

                case "name":
                    return Console.WriteLine(x.Key);

                case "age":
                    return Console.WriteLine(x.Value);

                case "name age":
                    return Console.WriteLine($"{x.Key} - {x.Value}");

                default:
                    throw new NotImplementedException();
            }

        }

        private static void PrintPeople(Dictionary<string, int> people,   Func<int, bool> filter,   Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in people)
            {
                if (filter(person.Value))
                    printer(person);
            }
        }
    }
}
