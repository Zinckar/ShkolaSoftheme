using System;

namespace RefValueType
{
    public class User 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public User(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public User Clone()
        {
            return new User(FirstName, LastName, Age);
        }
    }
}