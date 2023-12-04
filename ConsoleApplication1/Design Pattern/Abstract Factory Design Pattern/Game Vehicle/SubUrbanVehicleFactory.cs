namespace ConsoleApplication1.Design_Pattern.Abstract_Factory_Design_Pattern.Game_Vehicle
{
    public class SubUrbanVehicleFactory : VehicleFactory
    {
        public IVehicle2 createVehicle(string vehicleType)
        {
            switch (vehicleType)
            {
                case"car":
                    return new Car1();
                case "bus":
                    return new Bus1();
                case "truck":
                    return new Car1();
            }

            return null;
        }
    }
}