using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class Boss : Friend
    {
        public Boss(IMediator mediator, string name) : base(mediator)
        {
            this.Name = name;
        }

        public void Send(string msg)
        {
            mediator.Send(this, msg);
        }
    }
}
