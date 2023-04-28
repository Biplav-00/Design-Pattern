using System;
using System.Security.Cryptography;

namespace ConsoleApplication1.Design_Pattern.Factory_Design_Pattern.Vehicle_Example
{
    public class Car : Vehicle
    {
        public override void build(string name,double price)
        {
            Console.WriteLine("The price of {0} car is {1:C}",name,price);
        }
    }
}