namespace DesignPatterns.Structural.Decorator.example_1
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class HondaCity : IVehicle
    {
        public string Make => "HondaCity";

        public string Model => "CNG";

        public double Price => 1000000;
    }
}
