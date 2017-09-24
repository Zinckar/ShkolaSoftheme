using System;

namespace Lottery
{
    class Program
    {
        private const string IncorrectInput = "Incorrect input! Please input number from 0 to 9";
        static void Main(string[] args)
        {
            var numberQuantity = 6;
            LotteryTicket ticket = new LotteryTicket(numberQuantity);
            int[] userEnter = new int[numberQuantity];
            for (int i = 0; i < userEnter.Length; i++)
            {
                Console.WriteLine("Please, enter {0} number from 0 to 9", i + 1);
                userEnter[i] = InputNumbers();
            }
            Console.WriteLine("{0}Result{0}", Environment.NewLine);
            var k = 0;
            for (int i = 0; i < numberQuantity; i++)
            {
                if (ticket[i] == userEnter[i])
                {
                    Console.WriteLine("{0} number is correct", i + 1);
                    k++;
                }
                else
                {
                    Console.WriteLine("It was {0}", ticket[i]);
                }
            }
            Console.WriteLine("You guess {0} numbers", k);

            Console.ReadKey();

        }

        private static int InputNumbers()
        {
            string input = Console.ReadLine();
            int number;
            Int32.TryParse(input, out number);


            if (number > 0 && number < 10)
            {
                return number;
            }
            else
            {
                Console.WriteLine(IncorrectInput);  
            }
           
            return InputNumbers();
        }
    }
}