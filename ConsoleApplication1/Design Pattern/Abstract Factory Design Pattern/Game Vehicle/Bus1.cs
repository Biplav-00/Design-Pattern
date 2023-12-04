using System;

namespace ConsoleApplication1.Design_Pattern.Abstract_Factory_Design_Pattern.Game_Vehicle
{
    public class Bus1 : IVehicle2
    {
        public void speed(int km)
        {
            Console.WriteLine("The speed of bus is {0} km/hr",km);
        }

        public void wheels()
        {
            Console.WriteLine("The bus has six wheels");
        }

        public void comfort(string msg)
        {
            Console.WriteLine("Bus comfort message = {0}",msg);
        }
    }
}