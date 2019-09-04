using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class Message
    {
        public string Text;
        public MessagePriority Priority;

        public Message(string msg, MessagePriority p)
        {

            Text = msg;
            this.Priority = p;
        }
    }
}
