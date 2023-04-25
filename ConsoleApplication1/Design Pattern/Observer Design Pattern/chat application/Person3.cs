using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ConsoleApplication1.Design_Pattern.Observer_Design_Pattern.chat_application
{
    public class Person3 : ObserverInterface
    {
        private string name;

        public Person3(string name)
        {
            this.name = name;
        }
        public void update(string msg)
        {
            Console.WriteLine("{0} person received the {1} message : "+name,msg);
        }

        public string Name
        {
            get { return name; }
        }
    }
}