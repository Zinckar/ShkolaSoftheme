using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDescriptor
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeDescriptor descriptor1 = new ShapeDescriptor(new Point(1, 1), new Point(1, 2), new Point(2, 1));
            ShapeDescriptor descriptor2 = new ShapeDescriptor(new Point(1, 1), new Point(1, 2), new Point(2, 1), new Point(2, 2));
            ShapeDescriptor descriptor3 = new ShapeDescriptor(new Point(1, 1), new Point(2, 2));

            Console.WriteLine("This is {0}", descriptor1.ShapeType);
            Console.WriteLine("This is {0}", descriptor2.ShapeType);
            Console.WriteLine("This is {0}", descriptor3.ShapeType);

            Console.ReadKey();
        }
    }
}
