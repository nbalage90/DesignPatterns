using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    interface IMediator
    {
        void Register(Friend friend);
        void Send(Friend friend, string msg);
    }
}
