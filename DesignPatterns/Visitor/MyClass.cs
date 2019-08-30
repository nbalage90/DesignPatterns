using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class MyClass : IOriginalInterface
    {
        private int myInt = 5;

        public int MyInt
        {
            get { return myInt; }
            set { myInt = value; }
        }


        public void Accept(IVisitor visitor)
        {
            Console.WriteLine($"Initial value of the integer: {myInt}");
            visitor.Visit(this);
            Console.WriteLine($"\nValue of the integer now: {myInt}");
        }
    }
}
