using System;

namespace ConsoleApplication1.Design_Pattern.Decorator_Design_Pattern.Demo_Program
{
    public class ConcreteDecorator : IDecorator
    {
        public ConcreteDecorator(IComponent component) :base(component)
        {
            
        }

        public override void Build()
        {
            base.Build();
            Console.WriteLine("I am a adding item hahahaha");
        }
    }
}