using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Abstract Factory Pattern Demo***\n");

            IAnimalFactory wildAnimalFactory = new WildAnimalFactory();
            IDog wildDog = wildAnimalFactory.GetDog();
            wildDog.Speak();
            wildDog.Action();
            ITiger wildTiger = wildAnimalFactory.GetTiger();
            wildTiger.Speak();
            wildTiger.Action();

            Console.WriteLine("**********");

            IAnimalFactory petAnimalFactory = new PetAnimalFactory();
            IDog petDog = petAnimalFactory.GetDog();
            petDog.Speak();
            petDog.Action();
            ITiger petTiger = petAnimalFactory.GetTiger();
            petTiger.Speak();
            petTiger.Action();
        }
    }
}
