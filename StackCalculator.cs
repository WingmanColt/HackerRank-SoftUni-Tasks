using System;
using System.Collections.Generic;
using System.Linq;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var values = input.Split(' ');

            Stack<string> CalculatorStack = new Stack<string>(values.Reverse());


            while (CalculatorStack.Count > 1)
            {
                int firstOperand = int.Parse(CalculatorStack.Pop());
                string operand = CalculatorStack.Pop();
                int secondOperand = int.Parse(CalculatorStack.Pop());

                switch (operand)
                {
                    case "+":CalculatorStack.Push((firstOperand+secondOperand).ToString());
                        break;

                    case "-":CalculatorStack.Push((firstOperand-secondOperand).ToString());
                        break;

                    //default:CalculatorStack.Push(0.ToString());
                     //   break;
                }
            }
            Console.WriteLine(CalculatorStack.Pop());

        }
    }
}
