using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Design_Pattern.Facade_Design_Pattern.Computer__Simulation_Example
{
    public class Client
    {
        public void runSimulation()
        {
            Dictionary<string, string> obj = new Dictionary<string, string>();
            ComputerFacade computerFacade = new ComputerFacade();
            obj=computerFacade.runSimulation();
            foreach (var a in obj)
            {
                Console.WriteLine(a);
                
            }
        }
    }
}