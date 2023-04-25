using System;

namespace ConsoleApplication1.Design_Pattern.Decorator_Design_Pattern.Vehicle_Example
{
    public class SpecialOffer : VehicleDecorator
    {
        public SpecialOffer(IVehicle vehicle) : base(vehicle)
        {
        }
        public string offer { get; set; }
        public int discountPercentage { get; set; }

        public double price
        {
            get
            {
                double p = base.Price;
                int percentage = 100 - discountPercentage;

                return Math.Round(( p* percentage) / 100,2);



            }
        }
    }
}