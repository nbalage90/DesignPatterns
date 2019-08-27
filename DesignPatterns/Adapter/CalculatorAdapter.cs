using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class CalculatorAdapter
    {
        public double GetArea(Triangle triangle)
        {
            Calculator c = new Calculator();
            Rect rect = new Rect();
            rect.lenght = triangle.baseT;
            rect.width = 0.5 * triangle.height;
            return c.GetArea(rect);
        }
    }
}
