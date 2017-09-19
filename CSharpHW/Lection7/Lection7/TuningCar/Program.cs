using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuningCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() { Color = "Blue", Model = "Camaro", Year = 2002 };
            Console.WriteLine(car.Color);
            Console.WriteLine("After atelier: ");
            TuningAtelier.TuneCar(car);
            Console.WriteLine(car.Color);

            Console.ReadKey();
        }
    }
}
