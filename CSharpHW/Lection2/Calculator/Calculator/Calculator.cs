using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator

    {
        static void Main(string[] args)

        {
            double num1;
            double num2;
            double result;
            string[] operations = { "+", "-", "*", "/", "%" };


            while (true)
            {
                num1 = SetNumber("Please enter the first number: ");
                string operand = SetOperation(operations, "Please enter an operation (+, -, /, *, %): ");
                num2 = SetNumber("Please enter the second number: ");



                switch (operand)
                {
                    case "/":
                        result = num1 / num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "+":
                        result = num1 + num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "%":
                        result = num1 % num2;
                        break;
                    default:
                        result = 0;
                        break;
                }

                Console.WriteLine("{0} {1} {2} = {3}", num1, operand, num2, result.ToString(CultureInfo.InvariantCulture));
                Console.WriteLine("Try more? [y/n]");

                if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    return;
                }
                else
                {
                    Console.Clear();
                }
            }
        }


        private static double SetNumber(string output)
        {
            Console.Write(output);
            string input = Console.ReadLine();
            double parsed;
            while (!double.TryParse(input, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out parsed)
                || double.IsNaN((parsed)) || double.IsInfinity(parsed))
            {
                Console.WriteLine("Enter valid number:");
                input = Console.ReadLine();
            }
            return parsed;
        }


        private static string SetOperation(string[] operations, string outputText)
        {
            Console.Write(outputText);
            string input = Console.ReadLine();
            while (!operations.Contains(input))
            {
                Console.WriteLine("Try again");
                Console.Write(outputText);
                input = Console.ReadLine();
            }
            return input;
        }


    }
}