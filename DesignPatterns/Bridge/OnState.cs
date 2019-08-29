using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class OnState : IState
    {
        public void MoveState()
        {
            Console.WriteLine("On State");
        }
    }
}
