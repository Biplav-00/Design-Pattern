using System.Collections.Generic;

namespace ConsoleApplication1.Design_Pattern.Facade_Design_Pattern.Computer__Simulation_Example
{
    public class ComputerFacade
    {
        private KeyBoard keyBoard;
        private Procressor procressor;
        private Monitor monitor;

        public ComputerFacade()
        {
            keyBoard = new KeyBoard();
            procressor = new Procressor();
            monitor = new Monitor();
        }

        public Dictionary<string,string> runSimulation()
        {
            Dictionary<string, string> allInfo = new Dictionary<string, string>();
            allInfo.Add("Keyboard",keyBoard.typemsg());
            allInfo.Add("Procressor ",procressor.procress());
            allInfo.Add("Monitor",monitor.display());
            return allInfo;
        }
    }
}