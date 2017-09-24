namespace CarConstruct
{
    public class Engine
    {
        public string Type { get; set; }
        public int Power { get; set; }
        public double Volume { get; set; }

        public Engine(string type, int power, double volume)
        {
            Type = type;
            Power = power;
            Volume = volume;
        }
    }
}