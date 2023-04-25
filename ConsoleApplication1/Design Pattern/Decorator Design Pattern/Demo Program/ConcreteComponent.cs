using System;

namespace ConsoleApplication1.Design_Pattern.Decorator_Design_Pattern.Demo_Program
{
    public class ConcreteComponent : IComponent
    {
        public void Build()
        {
            Console.WriteLine("This is base builder inside the concrete component class");
        }
    }
}