using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Calculator
    {
        public double GetArea(Rect rect)
        {
            return rect.lenght * rect.width;
        }
    }
}
