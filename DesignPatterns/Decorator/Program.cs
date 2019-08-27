using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Decorator Pattern Demo***\n");
            ConcreteComponent cc = new ConcreteComponent();

            ConcreteDecoratorEx1 decorator1 = new ConcreteDecoratorEx1();
            decorator1.SetTheComponent(cc);
            decorator1.MakeHouse();

            ConcreteDecoratorEx2 decorator2 = new ConcreteDecoratorEx2();
            decorator2.SetTheComponent(decorator1);
            decorator2.MakeHouse();
        }
    }
}
