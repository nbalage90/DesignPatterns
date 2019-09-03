using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Memento Pattern Demo***\n");
            Originator originatorObject = new Originator();
            Memento mementoObject;
            originatorObject.State = "Initial state";

            mementoObject = originatorObject.GetTheMemento();
            originatorObject.State = "Intermediary state";

            originatorObject.RevertToState(mementoObject);
        }
    }
}
