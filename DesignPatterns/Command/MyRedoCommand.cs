using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class MyRedoCommand : ICommand
    {
        private Receiver receiver;

        public MyRedoCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public void Do()
        {
            receiver.OptionalTaskPriorToRedo();
            receiver.PerformRedo();
        }
    }
}
