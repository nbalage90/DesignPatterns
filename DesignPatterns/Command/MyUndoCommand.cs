using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class MyUndoCommand : ICommand
    {
        private Receiver receiver;

        public MyUndoCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void Do()
        {
            receiver.OptionalTaskPriorToUndo();
            receiver.PerformUndo();
        }
    }
}
