using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Command Pattern Demo***\n");
            Invoke invoker = new Invoke();
            Receiver intendedreceiver = new Receiver();

            MyUndoCommand undoCmd = new MyUndoCommand(intendedreceiver);
            invoker.SetCommand(undoCmd);
            invoker.ExecuteCommand();

            MyRedoCommand redoCmd = new MyRedoCommand(intendedreceiver);
            invoker.SetCommand(redoCmd);
            invoker.ExecuteCommand();
        }
    }
}
