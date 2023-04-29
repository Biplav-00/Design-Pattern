namespace ConsoleApplication1.Design_Pattern.Factory_Design_Pattern.Vehicle_Example_2
{
    public class VehicleFactory1
    {
        public IVehicle createVehicle(string vehicleName)
        {
            switch (vehicleName)
            {
                case "motorcycle":
                    return new MotorCycle();
                case "truck":
                    return new Truck();
            }

            return null;
        }
    }
}