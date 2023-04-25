using System.Collections.Generic;

namespace ConsoleApplication1.Design_Pattern.Decorator_Design_Pattern.Vehicle_Example
{
    public class HondaCity : IVehicle
    {
        private string make;
        public string Make
        {
            get { return "Honda City"; }
        }
        public string Model
        {
            get { return "Model is X25"; }
        }
        public double Price
        {
            get { return 250.00; }
        }
    }
}