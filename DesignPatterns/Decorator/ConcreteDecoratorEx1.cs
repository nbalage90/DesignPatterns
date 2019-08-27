using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class ConcreteDecoratorEx1 : AbstractDecorator
    {
        public override void MakeHouse()
        {
            base.MakeHouse();
            Console.WriteLine("***Using a decorator***");
            AddFloor();
        }

        private void AddFloor()
        {
            Console.WriteLine("I am making an additional floor on top of it.");
        }
    }
}
