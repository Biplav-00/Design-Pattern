namespace ConsoleApplication1.Design_Pattern.Abstract_Factory_Design_Pattern.Game_Vehicle
{
    public interface VehicleFactory
    {
        IVehicle2 createVehicle(string vehicleType);
    }
}