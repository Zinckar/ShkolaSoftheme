using System;

namespace CarConstruct
{
    public class Car
    {
        public Transmission Transmission { get; set; }
        public Color Color { get; set; }
        public Engine Engine { get; set; }

        public Car(Transmission transmission, Color color, Engine engine)
        {
            Transmission = transmission;
            Color = color;
            Engine = engine;
        }

        public override string ToString()
        {
            return String.Format("Car color is {0}{5}Transmission type is {1}{5}Engine is {2}, {3} horse power, volume {4}", Color.CarColor, Transmission.Type, Engine.Type, Engine.Power, Engine.Volume, Environment.NewLine);
        }
    }
}