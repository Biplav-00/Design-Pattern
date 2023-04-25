using System.Collections.Generic;
using System.Data;

namespace ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Ecommerce_Example
{
    public class Product : IProduct
    {
        private string productName;
        private int productPrice;
        private List<IUser> listUser;

        public Product(string productName,int productPrice)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            listUser = new List<IUser>();
        }
        public string ProductName
        {
            get { return productName; }
        }

        public int ProductPrice
        {
            get { return productPrice;}
            set
            {
                if (productPrice > value)
                {
                    productPrice = value;
                    notify();
                    
                }
            }
        }

        public void addUser(IUser user)
        {
          listUser.Add(user);  
        }

        public void removeUser(IUser user)
        {
            listUser.Remove(user);
        }

        public void notify()
        {
            foreach (var VARIABLE in listUser)
            {
                VARIABLE.update(this);
            }
        }
    }
}