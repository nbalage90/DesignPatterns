using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Mediator Pattern Demo***\n");

            ConcreteMediator mediator = new ConcreteMediator();

            Friend1 Amit = new Friend1(mediator, "Amit");
            Friend1 Sohel = new Friend1(mediator, "Sohel");
            Boss Raghu = new Boss(mediator, "Raghu");

            mediator.Register(Amit);
            mediator.Register(Sohel);
            mediator.Register(Raghu);
            mediator.DisplayDetails();

            Console.WriteLine("Communication starts among participants...");
            Amit.Send("Hi Sohel, can we discuss the mediator pattern?");
            Sohel.Send("Hi Amit, Yup, we can discuss now.");
            Raghu.Send("Please get back to work quickly.");

            Unknown unknown = new Unknown(mediator, "Jack");
            unknown.Send("Hello Gusy...");
        }
    }
}
