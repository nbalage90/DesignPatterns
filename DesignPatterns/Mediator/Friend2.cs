using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class Friend2 : Friend
    {
        public Friend2(IMediator mediator, string name) : base(mediator)
        {
            this.Name = name;
        }

        public void Send(string msg)
        {
            mediator.Send(this, msg);
        }
    }
}
