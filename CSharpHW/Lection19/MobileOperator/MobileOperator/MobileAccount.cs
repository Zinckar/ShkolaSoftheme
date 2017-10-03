using System;
using System.Collections.Generic;

namespace MobileOperator
{
    public class MobileAccount : IMobileAccount
    {
        public string Number { get; private set; }
        public string Name { get; private set; }
        private Operator Operator { get; set; }
        private List<User> AddressBook { get; set; }

        public MobileAccount(User user, Operator mobileOperator)
        {
            Operator = mobileOperator;
            Number = user.Number;
            Name = user.Name;
            AddressBook = new List<User>();
        }

        public void MakeCall(string toNumber)
        {
            foreach (var account in AddressBook)
            {
                if (account.Number == toNumber)
                {
                    Console.WriteLine("{0} is calling to {1}", Name, account.Name);
                    Operator.ProcessCall(Number, toNumber);
                    return;
                }
            }
            Console.WriteLine("{0} is calling to number {1}", Name, toNumber);

            Operator.ProcessCall(Number, toNumber);
        }

        public void SendSms(string toNumber, string text)
        {
            foreach (var account in AddressBook)
            {
                if (account.Number == toNumber)
                {
                    Console.WriteLine("{0} is sending sms to {1}", Name, account.Name);
                    Operator.ProcessSms(Number, toNumber, text);
                    return;
                }
            }
            Console.WriteLine("{0} is sending sms to number {1}", Name, toNumber);
            Operator.ProcessSms(Number, toNumber, text);
        }

        public void ReceiveCall(object sender, CallEventArgs e)
        {
            foreach (var account in AddressBook)
            {
                if (account.Number == e.FromNumber)
                {
                    Console.WriteLine("{0} is calling. Phone number : {1}", account.Name, account.Number);
                    Console.WriteLine();
                    return;
                }
            }

            Console.WriteLine("Unknown user is calling. Phone number is {0}", e.FromNumber);
            Console.WriteLine();

        }

        public void ReceiveSms(object sender, SmsEventArgs e)
        {
            foreach (var account in AddressBook)
            {
                if (account.Number == e.FromNumber)
                {
                    Console.WriteLine("New sms from {0}! Phone number : {1}", account.Name, account.Number);
                    Console.WriteLine("{0}", e.Text);
                    return;
                }
            }

            Console.WriteLine("Unknown user sent you an sms. Phone number is {0}", e.FromNumber);
            Console.WriteLine("Text : {0}", e.Text);
        }

        public void AddNumberToAddressBook(User user)
        {
            if (AddressBook.Exists(x => x.Number == user.Number))
            {
                throw new ArgumentException("User with same number already added in address book!");
            }
            AddressBook.Add(user);
        }

    }
}