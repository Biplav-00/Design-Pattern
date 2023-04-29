using System;

namespace ConsoleApplication1.Design_Pattern.Abstract_Factory_Design_Pattern.Game_Vehicle
{
    public class Truck1 : IVehicle2
    {
        public void speed(int km)
        {
            Console.WriteLine("The speed of truck is {0} km/hr",km);
        }

        public void wheels()
        {
            Console.WriteLine("The truck has 10 wheels");
        }

        public void comfort(string msg)
        {
            Console.WriteLine("The comfort in truck is = {0}",msg);
        }
    }
}