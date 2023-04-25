using System.Collections.Generic;

namespace ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Stock_Notifier
{
    public class VoteKosiStock : StockSubject
    {
        private string name;
        private int price;
        private List<IStockObserver> intrestedUsers;

        public VoteKosiStock(string name, int price)
        {
            this.name = name;
            this.price = price;
            intrestedUsers = new List<IStockObserver>();
        }
        
        public string Name
        {
            get { return name; }
        }

        public int Price
        {
            get { return price;}
            set
            {
                if (price != value)
                {
                    price = value;
                    notifyToAll();
                }
            }
        }

        public void addStockObserver(IStockObserver observer)
        {
            intrestedUsers.Add(observer);
        }

        public void removeStockObserver(IStockObserver observer)
        {
            intrestedUsers.Remove(observer);
        }

        public void notifyToAll()
        {
            foreach (var VARIABLE in intrestedUsers)
            {
                VARIABLE.update(this);
            }
        }
    }
}