using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Iterator
{
    public interface IIterator
    {
        void First();
        string Next();
        bool IsDone();
        string CurrentItem();
    }
}
