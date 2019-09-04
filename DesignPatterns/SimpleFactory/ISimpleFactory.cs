using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    abstract class ISimpleFactory
    {
        public abstract IAnimal CreateAnimal();
    }
}
