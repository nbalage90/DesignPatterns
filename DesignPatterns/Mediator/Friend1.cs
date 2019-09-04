using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class Friend1 : Friend
    {
        public Friend1(IMediator mediator, string name) : base(mediator)
        {
            this.Name = name;
        }

        public void Send(string msg)
        {
            mediator.Send(this, msg);
        }
    }
}
