using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class WildAnimalFactory : IAnimalFactory
    {
        public IDog GetDog()
        {
            return new WildDog();
        }

        public ITiger GetTiger()
        {
            return new WildTiger();
        }
    }
}
