using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IAnimalFactory
    {
        IDog GetDog();
        ITiger GetTiger();
    }
}
