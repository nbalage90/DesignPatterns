﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class PetAnimalFactory : IAnimalFactory
    {
        public IDog GetDog()
        {
            return new PetDog();
        }

        public ITiger GetTiger()
        {
            return new PetTiger();
        }
    }
}
