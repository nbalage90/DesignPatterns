using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Adapter Pattern Demo***\n");
            CalculatorAdapter cal = new CalculatorAdapter();
            Triangle t = new Triangle(20, 10);
            Console.WriteLine($"Area of Triangle is " + cal.GetArea(t) + " Square unit");
        }
    }
}
