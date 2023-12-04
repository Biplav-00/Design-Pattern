using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication1.Design_Pattern.Abstract_Factory_Design_Pattern.Game_Vehicle
{
    public class Car1 : IVehicle2
    {
        public void speed(int km)
        {
            Console.WriteLine("The speed of car is {0} km/hr",km);
        }

        public void wheels()
        {
            Console.WriteLine("The car has 4 wheels");
        }

        public void comfort(string msg)
        {
            Console.WriteLine("Car Comfort = "+msg);
        }
    }
}