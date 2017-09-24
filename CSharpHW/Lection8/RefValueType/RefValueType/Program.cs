using System;

namespace RefValueType
{
    class Program
    {
        private const string ChangedValues = "Changed values ";
        private const string ChangedUser = "Changed user 2: ";
        private const string Cloned = "Cloned User 1 to User 2. User 3 = User 2: ";

        static void Main(string[] args)
        {
            int b = 10;

            var a = b;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            a = 15;
            Console.WriteLine(ChangedValues);
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            User user1 = new User("Daniel", "Zhakobin", 24);

            User user2 = user1.Clone();
            User user3 = user2;

            Console.WriteLine(Cloned);
            Console.WriteLine("User1: {0} {1}, Age : {2}", user1.FirstName, user1.LastName, user1.Age);
            Console.WriteLine("User2: {0} {1}, Age : {2}", user2.FirstName, user2.LastName, user2.Age);
            Console.WriteLine("User3: {0} {1}, Age : {2}", user3.FirstName, user3.LastName, user3.Age);

            user2.FirstName = "Darth";
            user2.LastName = "Vader";
            user2.Age = 66;

            Console.WriteLine(ChangedUser);
            Console.WriteLine("User1: {0} {1}, Age : {2}", user1.FirstName, user1.LastName, user1.Age);
            Console.WriteLine("User2: {0} {1}, Age : {2}", user2.FirstName, user2.LastName, user2.Age);
            Console.WriteLine("User2: {0} {1}, Age : {2}", user3.FirstName, user3.LastName, user3.Age);

            Console.ReadKey();
        }
    }
}