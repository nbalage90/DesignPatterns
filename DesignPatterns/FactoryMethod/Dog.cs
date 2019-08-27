﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Dog says: Bow-bow.");
        }

        public void Action()
        {
            Console.WriteLine("Dogs prefer barking...\n");
        }
    }
}
