using System;
using System.Xml.Serialization;

namespace MobileOperator
{

    public class User
    {

        public string Name { get; set; }

        public string Number { get; set; }
        public User()
        {

        }

        public User(string number, string name)
        {
            Name = name;
            Number = number;
        }
    }
}