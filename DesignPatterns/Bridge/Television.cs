using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Television : ElectronicGoods
    {
        public override void MoveToCurrentState()
        {
            Console.WriteLine($"\nTelefivsion is functioning at:");
            state.MoveState();
        }
    }
}
