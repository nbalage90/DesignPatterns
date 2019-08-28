using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Facade Pattern Demo");
            RobotFacade rf1 = new RobotFacade();
            rf1.ConstructMilanoRobot();
            RobotFacade rf2 = new RobotFacade();
            rf2.ConstructRobonautRobot();
            rf1.DestroyMilanoRobot();
            rf2.DestroyRobonautRobot();
        }
    }
}
