using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Receiver
    {
        public void PerformUndo()
        {
            Console.WriteLine("Executing-MyUndoCommand");
        }

        public void PerformRedo()
        {
            Console.WriteLine("Executing-MyRedoCommand");
        }

        public void OptionalTaskPriorToUndo()
        {
            Console.WriteLine("Executing-Optional Tasks prior to execute undo command");
        }

        public void OptionalTaskPriorToRedo()
        {
            Console.WriteLine("Executing-optional Tasks prior to execute redo commnd");
        }
    }
}