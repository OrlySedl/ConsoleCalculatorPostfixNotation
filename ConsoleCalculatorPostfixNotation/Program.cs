using System;
using System.Collections.Generic;

namespace ConsoleCalculatorPostfixNotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string input = Console.ReadLine();
            Console.WriteLine(Calculate(input));
            Console.ReadLine();
        }

        static decimal Calculate(string expression)
        {
            Stack<decimal> stack = new Stack<decimal>();
            foreach (string item in expression.Split(' '))
            {

                if (Decimal.TryParse(item, out decimal number))
                {
                    stack.Push(number);
                }
                else
                {
                    decimal a = stack.Pop();
                    decimal b = stack.Pop();
                    switch (item)
                    {
                        case "+":
                            stack.Push(b + a);
                            break;
                        case "-":
                            stack.Push(b - a);
                            break;
                        case "*":
                            stack.Push(b * a);
                            break;
                        case "/":
                            stack.Push(b / a);
                            break;
                        default:
                            break;
                    }
                }
            }

            return stack.Peek();
        }
    }
}
