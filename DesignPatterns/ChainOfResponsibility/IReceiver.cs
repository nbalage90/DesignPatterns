using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    interface IReceiver
    {
        bool HandleMessage(Message message);
    }
}
