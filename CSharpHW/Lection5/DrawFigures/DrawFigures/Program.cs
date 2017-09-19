using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            var symbol = "*";
            var figure = 0;

            while (true)
            {
                
                Console.Write("Enter size of figure: ");
                try
                {
                    size = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                
                Console.Write("Choose figure type (1 - Triangle, 2 - Square, 3 - Romb): ");
                figure = Console.Read();
                switch (figure)
                {
                    case '1':
                        DrawTriangle(size, symbol);
                        break;
                    case '2':
                        DrawSquare(size, symbol);
                        break;
                    case '3':
                        DrawRomb(size, symbol);
                        break;
                    default:
                        Console.Clear();
                        break;
                }
                Console.WriteLine("Press q to quit");
                if (Console.ReadKey().Key == ConsoleKey.Q)
                {
                    Environment.Exit(1);
                }
                else
                {
                    Console.Read();
                    Console.Clear(); 
                }
            }
            }

        private static void DrawTriangle(int size, string symbol)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        private static void DrawSquare(int size, string symbol)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        private static void DrawRomb(int size, string symbol)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < (size - i); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(symbol);
                }

                for (int k = 1; k < i; k++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            for (int i = size - 1; i >= 1; i--)
            {
                for (int j = 0; j < (size - i); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(symbol);
                }
                for (int k = 1; k < i; k++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    
    } 
}
