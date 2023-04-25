using System;

namespace ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Youtube_Example
{
    public class Suscriber1 : IObserver
    {
        public void update(string msg)
        {
            Console.WriteLine("Susciber 1 : "+msg);
        }
    }
}