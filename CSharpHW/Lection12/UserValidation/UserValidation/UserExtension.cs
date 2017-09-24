using System;
using System.Collections.Generic;

namespace UserValidation
{
    static class UserExtension
    {
        private const string EnterCredentials = "Please enter your credentials to register:";
        private const string EnterName = "Enter your Name";
        private const string EnterEmail = "Enter your email";
        private const string EnterPassword = "Enter your password";
        public static User AddUser()
        {
            Console.WriteLine(EnterCredentials);
            Console.WriteLine();

            Console.WriteLine(EnterName);
            var name = Console.ReadLine();

            Console.WriteLine(EnterEmail);
            var email = Console.ReadLine();

            Console.WriteLine(EnterPassword);
            var password = Console.ReadLine();

            return new User(name, password, email);
        }

        public static User CheckUser(List<User> listOfUsers, string emailOrName, string pass)
        {
            foreach (var user in listOfUsers)
            {
                if (emailOrName.Contains("@"))
                {
                    if (user.ValidateUser(new User(null, pass, emailOrName)))
                    {
                        var newUser = AddUser();
                        Console.WriteLine(newUser.GetFullInfo());
                        return newUser;
                    }
                }
                else
                {
                    if (user.ValidateUser(new User(emailOrName, pass, null)))
                    {
                        var newUser = AddUser();
                        Console.WriteLine(newUser.GetFullInfo());
                        return newUser;
                    }
                }
            }
            return null;
        }

        public static bool IsUserExit(List<User> listOfUsers)
        {
            string exit = "exit";
            foreach (var user in listOfUsers)
            {
                if (user.Name == exit && user.Email == exit && user.Password == exit)
                {
                    return true;
                }
            }
            return false;
        }
    }
}