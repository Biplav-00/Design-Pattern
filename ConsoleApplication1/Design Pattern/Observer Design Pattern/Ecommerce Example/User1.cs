using System;

namespace ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Ecommerce_Example
{
    public class User1 : IUser
    {
        private string userName;
        public User1(string userName)
        {
            this.userName = userName;
        }

        public void update(IProduct product1)
        {
            if (product1 is Product product)
            {
                Console.WriteLine("The price of {0} is decrease and new price is {1}",product.ProductName,product.ProductPrice);
            }
        }
    }
}