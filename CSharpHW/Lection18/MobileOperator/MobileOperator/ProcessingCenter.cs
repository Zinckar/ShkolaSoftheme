namespace MobileOperator
{
    public static class ProcessingCenter
    {
        public static void ProcessAllActions()
        {
            var mobileOperator = new Operator();

            var user1 = new User("11111", "John");
            var user2 = new User("22222", "Smith");
            var user3 = new User("33333", "Pablo");
            var user4 = new User("44444", "Jenny");

            var account1 = new MobileAccount(user1, mobileOperator);
            var account2 = new MobileAccount(user2, mobileOperator);
            var account3 = new MobileAccount(user3, mobileOperator);
            var account4 = new MobileAccount(user4, mobileOperator);

            mobileOperator.Register(account1);
            mobileOperator.Register(account2);
            mobileOperator.Register(account3);
            mobileOperator.Register(account4);

            account1.AddNumberToAddressBook(user2);
            account1.AddNumberToAddressBook(user3);

            account2.AddNumberToAddressBook(user4);
            account2.AddNumberToAddressBook(user3);

            account3.AddNumberToAddressBook(user1);
            account3.AddNumberToAddressBook(user2);

            account4.AddNumberToAddressBook(user2);
            account4.AddNumberToAddressBook(user1);

            account1.MakeCall(account3.Number);

            account4.MakeCall(account2.Number);

            account4.SendSms(account2.Number, "Hi, how are you?");
        }
    }
}