namespace ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Youtube_Example
{
    public interface ISubject
    {
        void registerObserver(IObserver observer);
        void unRegisterObserver(IObserver observer);
        void notifyObserver(string msg);
    }
}