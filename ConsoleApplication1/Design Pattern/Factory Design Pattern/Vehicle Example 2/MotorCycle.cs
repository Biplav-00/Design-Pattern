using System;

namespace ConsoleApplication1.Design_Pattern.Factory_Design_Pattern.Vehicle_Example_2
{
    public class MotorCycle : IVehicle
    {
        public void startEngine()
        {
            Console.WriteLine("Motorcycle  engin is started");
        }

        public void stopEngine()
        {
            Console.WriteLine("Motorcycle engin is stopped");
        }
    }
}