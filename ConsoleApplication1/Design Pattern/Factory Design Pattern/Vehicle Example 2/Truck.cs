using System;

namespace ConsoleApplication1.Design_Pattern.Factory_Design_Pattern.Vehicle_Example_2
{
    public class Truck : IVehicle
    {
        public void startEngine()
        {
            Console.WriteLine("Truck engine is being start");
        }

        public void stopEngine()
        {
            Console.WriteLine("Truck engine is being stopped");
        }
    }
}