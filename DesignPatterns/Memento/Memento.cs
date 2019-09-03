using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Memento
    {
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
