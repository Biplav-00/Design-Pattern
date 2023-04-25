namespace ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.chat_application
{
    public interface subjectInterface
    {
        void addUser(ObserverInterface observerInterface);
        void deleteUser(ObserverInterface observerInterface);
        void notifyToUser();
    }
}