using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Simple Factory Pattern Demo***\n");
            IAnimal preferredType = null;
            ISimpleFactory simpleFactory = new SimpleFactory();
            preferredType = simpleFactory.CreateAnimal();
            preferredType.Speak();
            preferredType.Action();
        }
    }
}
