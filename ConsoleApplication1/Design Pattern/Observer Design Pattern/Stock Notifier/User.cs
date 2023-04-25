using System;

namespace ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Stock_Notifier
{
    public class User : IStockObserver
    {
        private string name;

        public User(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
        public void update(StockSubject subject)
        {
            if (subject is VoteKosiStock voteKosiStock)
            {
                Console.WriteLine("The {0} stock price is change to {1:C}",voteKosiStock.Name,voteKosiStock.Price);
            }
        }
    }
}