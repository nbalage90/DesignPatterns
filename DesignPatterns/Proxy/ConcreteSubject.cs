using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class ConcreteSubject : Subject
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("ConcreteSubject.DoWSomeWork()");
        }
    }
}
