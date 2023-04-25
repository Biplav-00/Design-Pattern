namespace ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Game_Task_1
{
    public interface Subject
    {
        void addObserver(Observer observer);
        void removeObserver(Observer observer);
        void notifyToObserver();
    }
}