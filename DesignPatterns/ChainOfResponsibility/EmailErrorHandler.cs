using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class EmailErrorHandler : IReceiver
    {
        private IReceiver nextReceiver;

        public EmailErrorHandler(IReceiver nextReceiver)
        {
            this.nextReceiver = nextReceiver;
        }

        public bool HandleMessage(Message message)
        {
            if (message.Text.Contains("Email"))
            {
                Console.WriteLine($"EmailErrorHandler processed {message.Priority} priority issue: {message.Text}");
                return true;
            }
            else
            {
                if (nextReceiver != null)
                {
                    nextReceiver.HandleMessage(message);
                }

                return false;
            }
        }
    }
}
