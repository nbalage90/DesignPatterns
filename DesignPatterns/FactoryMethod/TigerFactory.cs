using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class TigerFactory : IAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Tiger();
        }
    }
}
