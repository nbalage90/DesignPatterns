﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Ford : BasicCar
    {
        public Ford(string m)
        {
            ModelName = m;
        }

        public override BasicCar Clone()
        {
            return (Ford)this.MemberwiseClone();
        }
    }
}
