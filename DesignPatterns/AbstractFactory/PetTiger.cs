using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class PetTiger : ITiger
    {
        public void Speak()
        {
            Console.WriteLine("Pet Tiger says: Halum.");
        }

        public void Action()
        {
            Console.WriteLine("Pet Tiger play in an animal circus.\n");
        }
    }
}
