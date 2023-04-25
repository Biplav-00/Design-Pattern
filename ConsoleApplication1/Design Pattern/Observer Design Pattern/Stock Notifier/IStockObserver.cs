namespace ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Stock_Notifier
{
    public interface IStockObserver
    {
        void update(StockSubject subject);
    }
}