using System;
using System.Collections.Generic;

namespace MobileOperator
{
    public static class ProcessingCenter
    {
        public static void ProcessAllActions()
        {
            Console.WriteLine("xml or zip:");

            Operator mobileOperator = new Operator(Console.ReadLine());
            foreach (var user in mobileOperator.RegisteredUsers)
            {
                Console.WriteLine(user.Name);
                Console.WriteLine(user.Number);
                Console.WriteLine(user.AddressBook.Count + " accounts in address book");
            }
            Console.ReadKey();
        }
    }
}