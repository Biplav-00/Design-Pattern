namespace ConsoleApplication1.Design_Pattern.Factory_Design_Pattern.Vehicle_Example
{
    public class VehicleFactory
    {
        public Vehicle sale(string vehicleType)
        {
            switch (vehicleType)
            {
                case "car":
                    
                    return new Car();
            }

            return null;
        }
    }
}