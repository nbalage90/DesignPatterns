using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class VCD : ElectronicGoods
    {
        public override void MoveToCurrentState()
        {
            Console.WriteLine("\nVCD is functioning at:");
            state.MoveState();
        }
    }
}
