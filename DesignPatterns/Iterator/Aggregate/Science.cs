using Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Aggregate
{
    public class Science : ISubjects
    {
        private LinkedList<string> Subjects;

        public Science()
        {
            Subjects = new LinkedList<string>();
            Subjects.AddFirst("Maths");
            Subjects.AddFirst("Comp. Sc.");
            Subjects.AddFirst("Physics");
        }

        public IIterator CreateIterator()
        {
            return new ScienceIterator(Subjects);
        }
    }
}
