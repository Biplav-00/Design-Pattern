namespace ConsoleApplication1.Design_Pattern.Abstract_Factory_Design_Pattern.Game_Vehicle
{
    public class UrbanVehicleFactor : VehicleFactory
    {
        public IVehicle2 createVehicle(string vehicleType)
        {
            switch (vehicleType)
            {
                case"bus":
                    return new Bus1();
                case "car":
                    return new Car1();
                case "truck":
                    return new Truck1();

            }

            return null;

        }

        
    }
}