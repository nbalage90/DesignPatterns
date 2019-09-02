using Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Aggregate
{
    public interface ISubjects
    {
        IIterator CreateIterator();
    }
}
