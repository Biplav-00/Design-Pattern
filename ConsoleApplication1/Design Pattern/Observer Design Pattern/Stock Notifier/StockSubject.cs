namespace ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Stock_Notifier
{
    public interface StockSubject
    {
        void addStockObserver(IStockObserver observer);
        void removeStockObserver(IStockObserver observer);
        void notifyToAll();
    }
}