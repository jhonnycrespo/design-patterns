namespace DesignPatterns.Structural.Decorator.example_1
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public abstract class VehicleDecorator : IVehicle
    {
        private IVehicle _vehicle;

        public VehicleDecorator(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public string Make => _vehicle.Make;

        public string Model => _vehicle.Model;

        public double Price => _vehicle.Price;
    }
}
