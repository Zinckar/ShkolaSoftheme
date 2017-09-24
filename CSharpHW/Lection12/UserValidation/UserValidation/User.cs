using System;

namespace UserValidation
{
    public class User : IUser, IValidator
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public User(string name, string password, string email)
        {
            Name = name;
            Password = password;
            Email = email;
        }

        public string GetFullInfo()
        {
            return string.Format("Name : {0}{3}Email : {1}{3}Password : {2}{3}", Name, Email, Password, Environment.NewLine);
        }

        public bool ValidateUser(IUser user)
        {
            if (!string.IsNullOrEmpty(user.Name))
            {
                if (Name == user.Name && Password == user.Password)
                {
                    Console.WriteLine("Last time you were in system {0}", DateTime.Now.TimeOfDay);
                    return true;
                }
                return false;

            }
            if (!string.IsNullOrEmpty(user.Email))
            {
                if (Email == user.Email && Password == user.Password)
                {
                    Console.WriteLine("Last time you were in system {0}", DateTime.Now.TimeOfDay);
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}