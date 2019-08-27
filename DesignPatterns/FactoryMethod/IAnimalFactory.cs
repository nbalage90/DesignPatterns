using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class IAnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }
}
