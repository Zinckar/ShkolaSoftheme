using System;

namespace MobileOperator
{
    public static class ProcessingCenter
    {
        public static void ProcessAllActions()
        {
            Operator mobileOperator = new Operator();

            User user1 = new User("111111", "John");
            User user2 = new User("222222", "Smith");
            User user3 = new User("333333", "Pablo");
            User user4 = new User("444444", "Jenny");
            User user5 = new User("555555", "Billy");
            User user6 = new User("666666", "Michael");

            MobileAccount account1 = new MobileAccount(user1, mobileOperator);
            MobileAccount account2 = new MobileAccount(user2, mobileOperator);
            MobileAccount account3 = new MobileAccount(user3, mobileOperator);
            MobileAccount account4 = new MobileAccount(user4, mobileOperator);
            MobileAccount account5 = new MobileAccount(user5, mobileOperator);
            MobileAccount account6 = new MobileAccount(user6, mobileOperator);

            mobileOperator.Register(account1);
            mobileOperator.Register(account2);
            mobileOperator.Register(account3);
            mobileOperator.Register(account4);
            mobileOperator.Register(account5);
            mobileOperator.Register(account6);

            account1.AddNumberToAddressBook(user2);
            account1.AddNumberToAddressBook(user3);

            account2.AddNumberToAddressBook(user4);
            account2.AddNumberToAddressBook(user3);

            account3.AddNumberToAddressBook(user1);
            account3.AddNumberToAddressBook(user2);

            account4.AddNumberToAddressBook(user2);
            account4.AddNumberToAddressBook(user1);

            account5.AddNumberToAddressBook(user2);
            account5.AddNumberToAddressBook(user3);
            account5.AddNumberToAddressBook(user4);

            account6.AddNumberToAddressBook(user1);
            account6.AddNumberToAddressBook(user2);
            account6.AddNumberToAddressBook(user5);

            account1.MakeCall(account2.Number);
            account4.MakeCall(account2.Number);
            account1.MakeCall(account5.Number);
            account4.MakeCall(account2.Number);
            account3.MakeCall(account6.Number);
            account4.MakeCall(account2.Number);
            account2.MakeCall(account1.Number);
            account4.MakeCall(account6.Number);
            account2.MakeCall(account1.Number);
            account1.MakeCall(account2.Number);
            account6.MakeCall(account5.Number);
            account6.MakeCall(account2.Number);
            account6.MakeCall(account1.Number);
            account6.MakeCall(account4.Number);
            account6.MakeCall(account4.Number);
            account6.MakeCall(account3.Number);
            account5.MakeCall(account4.Number);
            account5.MakeCall(account6.Number);
            account5.MakeCall(account2.Number);
            account5.MakeCall(account4.Number);
            account5.MakeCall(account1.Number);

            account4.SendSms(account2.Number, "Hi, how are you?");
            account4.SendSms(account1.Number, "Hi, how are you?");
            account2.SendSms(account4.Number, "Hi, how are you?");
            account3.SendSms(account6.Number, "Hi, how are you?");
            account4.SendSms(account2.Number, "Hi, how are you?");
            account1.SendSms(account4.Number, "Hi, how are you?");
            account4.SendSms(account6.Number, "Hi, how are you?");
            account2.SendSms(account1.Number, "Hi, how are you?");
            account3.SendSms(account1.Number, "Hi, how are you?");
            account5.SendSms(account6.Number, "Hi, how are you?");
            account5.SendSms(account1.Number, "Hi, how are you?");
            account5.SendSms(account1.Number, "Hi, how are you?");
            account2.SendSms(account3.Number, "Hi, how are you?");
            account3.SendSms(account1.Number, "Hi, how are you?");
            account4.SendSms(account2.Number, "Hi, how are you?");
            account5.SendSms(account3.Number, "Hi, how are you?");
            account5.SendSms(account1.Number, "Hi, how are you?");
            account6.SendSms(account4.Number, "Hi, how are you?");
            account5.SendSms(account1.Number, "Hi, how are you?");

            Console.WriteLine("Five most common numbers");
            var commonNumbers = mobileOperator.GetFiveMostCommonNumbers();
            foreach (var number in commonNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            Console.WriteLine("Five most active account numbers");
            var activeNumbers = mobileOperator.GetFiveMostActiveNumbers();

            foreach (var num in activeNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}