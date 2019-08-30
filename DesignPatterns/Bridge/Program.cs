using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Bridge Pattern Demo***\n");
            Console.WriteLine("\nDealing with a Television:");

            ElectronicGoods eItem = new Television();
            IState presentState = new OnState();
            eItem.Stat = presentState;
            eItem.MoveToCurrentState();
            presentState = new OffState();
            eItem.Stat = presentState;
            eItem.MoveToCurrentState();

            Console.WriteLine("\n\nDealing with a VCD:");
            presentState = new OnState();
            eItem = new VCD();
            eItem.Stat = presentState;
            eItem.MoveToCurrentState();

            presentState = new OffState();
            eItem.Stat = presentState;
            eItem.MoveToCurrentState();
        }
    }
}
