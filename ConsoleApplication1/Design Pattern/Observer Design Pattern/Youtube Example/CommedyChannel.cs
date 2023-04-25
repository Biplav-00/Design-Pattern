using System.Collections.Generic;

namespace ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Youtube_Example
{
    public class CommedyChannel : ISubject
    {
        private List<IObserver> observerList;

        public CommedyChannel()
        {
            observerList = new List<IObserver>();
        }
        public void registerObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void unRegisterObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }

        public void notifyObserver(string msg)
        {
            foreach (var VARIABLE in observerList)
            {
                VARIABLE.update(msg);
            }
        }

        public void addNewVideo(string msg)
        {
            notifyObserver(msg);
        }
    }
}