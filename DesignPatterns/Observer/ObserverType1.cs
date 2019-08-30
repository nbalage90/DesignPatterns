using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class ObserverType1 : IObserver
    {
        private string nameOfObserver;

        public ObserverType1(string name)
        {
            this.nameOfObserver = name;
        }


        public void Update(int i)
        {
            Console.WriteLine($"{nameOfObserver} has received an alert: Someone has updated myValue in Subject to: {i}");
        }
    }
}
