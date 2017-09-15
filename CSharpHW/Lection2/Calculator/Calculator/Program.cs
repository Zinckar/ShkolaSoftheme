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
    class Program

    {
        static void Main(string[] args)

        {
            double num1;
            double num2;
            double result;
            string[] operations = {"+", "-", "*", "/", "%"};


            while (true)
            {
                num1 = SetNumber( "Please enter the first number: ");
                string operand = SetOperation(operations, "Please enter an operation (+, -, /, *, %): ");
                num2 = SetNumber("Please enter the second number: ");

                while (num2 == 0 && (operand == "/" || operand == "%"))
                {
                    Console.WriteLine("Division by zero. Choose another number");
                    num2 = SetNumber("Please enter the second number: ");
                }

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


                Console.WriteLine(num1 + " " + operand + " " + num2 + " = " + Math.Round(result, 2));

                Console.WriteLine("Try more? [y/n]");
            
                if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    Environment.Exit(0);
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
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Enter valid number;");
            }
            return double.Parse(input, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
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