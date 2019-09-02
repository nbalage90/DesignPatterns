using Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Aggregate
{
    public class Arts : ISubjects
    {
        private string[] Subjects;

        public Arts()
        {
            Subjects = new[] { "Bengali", "English" };
        }

        public IIterator CreateIterator()
        {
            return new ArtsIterator(Subjects);
        }
    }
}
