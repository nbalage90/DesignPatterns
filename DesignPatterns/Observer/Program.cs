using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Observer Pattern Demo***\n");

            IObserver myObserver1 = new ObserverType1("Roy");
            IObserver myObserver2 = new ObserverType1("Kevin");
            IObserver myObserver3 = new ObserverType2("Bose");

            Subject subject = new Subject();
            subject.Register(myObserver1);
            subject.Register(myObserver2);
            subject.Register(myObserver3);

            Console.WriteLine("Setting Flag = 5");
            subject.Flag = 5;

            subject.Unregister(myObserver1);
            Console.WriteLine("\nSetting Flag = 50"); ;
            subject.Flag = 50;

            subject.Register(myObserver1);
            Console.WriteLine("\nSetting Flag = 100");
            subject.Flag = 100;
        }
    }
}
