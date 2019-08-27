using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class ConcreteComponent : Component
    {
        public override void MakeHouse()
        {
            Console.WriteLine("Original House is complete. It is closed for modification");
        }
    }
}
