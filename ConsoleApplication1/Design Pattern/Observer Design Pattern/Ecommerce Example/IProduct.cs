namespace ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.Ecommerce_Example
{
    public interface IProduct
    {
        void addUser(IUser user);
        void removeUser(IUser user);
        void notify();
    }
}