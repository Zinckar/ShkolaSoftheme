using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualHumans
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Dan", "Zhakobin");
            Human human2 = new Human("Dan", "Zhakobin");

            Console.WriteLine(human1.Equals(human2));

            Console.ReadKey();
        }
    }
}
