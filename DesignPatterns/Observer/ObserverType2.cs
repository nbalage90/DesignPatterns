using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class ObserverType2 : IObserver
    {
        string nameOfObserver;

        public ObserverType2(string name)
        {
            this.nameOfObserver = name;
        }

        public void Update(int i)
        {
            Console.WriteLine($"{nameOfObserver} notified: myValue in Subject at present: {i}");
        }
    }
}
