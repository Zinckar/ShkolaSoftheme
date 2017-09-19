using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualHumans
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; private set; }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Human(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Age = DateTime.Now.Year - BirthDate.Year;
        }

        public bool Equals(Human human2)
        {
            if (FirstName == human2.FirstName && LastName == human2.LastName &&
                BirthDate == human2.BirthDate)
            {
                return true;
            }
            return false;
        }
    }
}
