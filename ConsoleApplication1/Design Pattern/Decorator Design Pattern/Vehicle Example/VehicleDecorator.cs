namespace ConsoleApplication1.Design_Pattern.Decorator_Design_Pattern.Vehicle_Example
{
    public abstract class VehicleDecorator : IVehicle
    {
        private IVehicle _vehicle;

        public VehicleDecorator(IVehicle vehicle)
        {
            this._vehicle = vehicle;
        }
        public string Make
        {
            get {return _vehicle.Make; }
        }
        public string Model
        {
            get { return _vehicle.Model; }
        }
        public double Price
        {
            get { return _vehicle.Price; }
        }
    }
}