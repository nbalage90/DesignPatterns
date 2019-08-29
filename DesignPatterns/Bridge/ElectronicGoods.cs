using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract class ElectronicGoods
    {
        protected IState state;
        public IState Stat
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        abstract public void MoveToCurrentState();
    }
}
