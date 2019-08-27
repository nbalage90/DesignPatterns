using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class AbstractDecorator : Component
    {
        protected Component com;
        public void SetTheComponent(Component c)
        {
            com = c;
        }

        public override void MakeHouse()
        {
            if (com != null)
            {
                com.MakeHouse();
            }
        }
    }
}
