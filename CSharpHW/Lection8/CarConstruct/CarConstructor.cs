using System.Linq.Expressions;

namespace CarConstruct
{
    public class CarConstructor
    {

        public Car Construct(Transmission transmission, Color color, Engine engine)
        {
            return new Car(transmission, color, engine);
        }

        public Car Reconstruct(Car car)
        {
            var type = "gas";
            var power = 200;
            var volume = 3.0;

            car.Engine = new Engine(type, power, volume);

            return car;
        }
    }
}