using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Originator
    {
        Memento myMemento;
        private string state;

        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine($"Current State: {state}");
            }
        }

        public Memento GetTheMemento()
        {
            myMemento = new Memento();
            myMemento.State = state;
            return myMemento;
        }

        public void RevertToState(Memento previousMemento)
        {
            Console.WriteLine("Restoring to previous state...");
            this.state = previousMemento.State;
            Console.WriteLine($"Current State: {state}");
        }
    }
}
