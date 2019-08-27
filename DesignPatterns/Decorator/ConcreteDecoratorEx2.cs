using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class ConcreteDecoratorEx2 : AbstractDecorator
    {
        public override void MakeHouse()
        {
            Console.WriteLine("");
            base.MakeHouse();
            Console.WriteLine("***Using another decorator***");
            PaintTheHouse();
        }

        private void PaintTheHouse()
        {
            Console.WriteLine("Now I am painting the house");
        }
    }
}
