using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class OffState : IState
    {
        public void MoveState()
        {
            Console.WriteLine("Off State");
        }
    }
}
