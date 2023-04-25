using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.chat_application
{
    public class ChatRoom : subjectInterface
    {
        private List<ObserverInterface> _observerInterfaces = new List<ObserverInterface>();
        private string name;

        public ChatRoom(string name)
        {
            this.name = name;
        }
        public void addUser(ObserverInterface observerInterface)
        {
            Console.WriteLine("New Person joined "+name);
            _observerInterfaces.Add(observerInterface);
        }

        public void deleteUser(ObserverInterface observerInterface)
        {
            Console.WriteLine("{0} is deleted"+name);
            _observerInterfaces.Remove(observerInterface);
        }

        public void notifyToUser()
        {
            foreach (var VARIABLE in _observerInterfaces)
            {
                VARIABLE.update("New Message received");
            }
        }
    }
}