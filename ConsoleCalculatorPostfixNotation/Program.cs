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

        static int Calculate(string expression)
        {
            Stack<int> stack = new Stack<int>();
            foreach (string item in expression.Split(' '))
            {
                try
                {
                    int number = Int32.Parse(item);
                    stack.Push(number);
                }
                catch (FormatException)
                {
                    int a = stack.Pop();
                    int b = stack.Pop();
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
