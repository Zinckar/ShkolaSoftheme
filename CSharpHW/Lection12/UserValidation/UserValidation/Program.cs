using System;
using System.Collections.Generic;

namespace UserValidation
{
    internal class Program
    {
        private const string EnterNameOrEmail = "Enter your name or email";
        private const string EnterPassword = "Enter your password";

        private static void Main(string[] args)
        {
            var list = new List<User>();

            if (list.Count == 0)
            {
                var newUser = UserExtension.AddUser();
                Console.WriteLine(newUser.GetFullInfo());
                list.Add(newUser);
            }
            while (!UserExtension.IsUserExit(list))
            {
                Console.WriteLine(EnterNameOrEmail);
                var nameOrEmail = Console.ReadLine();

                Console.WriteLine(EnterPassword);
                var pass = Console.ReadLine();

                var newUser = UserExtension.CheckUser(list, nameOrEmail, pass);

                if (newUser != null)
                {
                    list.Add(newUser);
                }
            }
        }
    }
}