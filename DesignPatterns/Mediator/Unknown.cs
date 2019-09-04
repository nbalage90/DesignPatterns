using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class Unknown : Friend
    {
        public Unknown(IMediator mediator, string name) : base(mediator)
        {
            this.Name = name;
        }

        public void Send(string msg)
        {
            mediator.Send(this, msg);
        }
    }
}
