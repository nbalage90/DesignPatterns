using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    abstract class Friend
    {
        protected IMediator mediator;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Friend(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
