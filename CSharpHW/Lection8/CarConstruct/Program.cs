using System;

namespace CarConstruct
{
    class Program
    {
        private const string Before = "Before reconstruction";
        private const string After = "After reconstruction";

        static void Main(string[] args)
        {
            var transmissionType = "manual";
            var carColor = "red";
            var engineType = "electrical";
            var engineVolume = 4.5;
            var enginePower = 200;

            Transmission manualTransmision = new Transmission(transmissionType);
            Color color = new Color(carColor);
            Engine engine = new Engine(engineType, enginePower, engineVolume);



            CarConstructor carConstructor = new CarConstructor();
            Car car = carConstructor.Construct(manualTransmision, color, engine);

            Console.WriteLine(Before);
            Console.WriteLine(car);
            Console.WriteLine();
            Console.WriteLine(After);
            carConstructor.Reconstruct(car);
            Console.WriteLine(car);

            Console.ReadKey();
        }
    }
}