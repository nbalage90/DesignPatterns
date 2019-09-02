using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Invoke
    {
        ICommand commandToBePerformed;

        public void SetCommand(ICommand command)
        {
            this.commandToBePerformed = command;
        }

        public void ExecuteCommand()
        {
            commandToBePerformed.Do();
        }
    }
}
