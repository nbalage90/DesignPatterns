using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Dog says: Bow-wow.");
        }

        public void Action()
        {
            Console.WriteLine("Dogs prefer barking...");
        }
    }
}
