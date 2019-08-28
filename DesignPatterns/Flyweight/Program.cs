using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Flyweight Pattern Demo***\n");
            RobotFactory myfactory = new RobotFactory();
            IRobot shape = myfactory.GetRobotFromFactory("Small");
            shape.Print();
            for (int i = 0; i < 2; i++)
            {
                shape = myfactory.GetRobotFromFactory("Small");
                shape.Print();
            }
            int NumOfdistinctRobots = myfactory.TotalObjectsCreated;
            Console.WriteLine($"\nNow, total numbers of distinct robot objects is {NumOfdistinctRobots}");

            for (int i = 0; i < 5; i++)
            {
                shape = myfactory.GetRobotFromFactory("Large");
                shape.Print();
            }

            NumOfdistinctRobots = myfactory.TotalObjectsCreated;
            Console.WriteLine($"\nDistinct Robot objects creted till now = {NumOfdistinctRobots}");
        }
    }
}
