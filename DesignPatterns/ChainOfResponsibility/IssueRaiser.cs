using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class IssueRaiser
    {
        public IReceiver setFirstReceiver;
        public IssueRaiser(IReceiver firstReceiver)
        {
            this.setFirstReceiver = firstReceiver;
        }

        public void RaiseMessage(Message message)
        {
            if (setFirstReceiver != null)
            {
                setFirstReceiver.HandleMessage(message);
            }
        }
    }
}
