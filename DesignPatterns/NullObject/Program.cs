using System;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Null Object Pattern Demo***\n");
            string input = string.Empty;
            int totalObjects = 0;
            while (true)
            {
                Console.WriteLine("Enter your choice (Type 'a' for Bus, 'b' for Train)");
                input = Console.ReadLine();
                IVehicle vehicle = null;
                switch (input)
                {
                    case "a":
                        vehicle = new Bus();
                        break;
                    case "b":
                        vehicle = new Train();
                        break;
                }
                totalObjects = Bus.busCount = Train.trainCount;
                vehicle.Travel();
                Console.WriteLine($"Total objects created in the system = {totalObjects}");
            }
        }
    }
}
