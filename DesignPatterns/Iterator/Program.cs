using Iterator.Aggregate;
using Iterator.Iterator;
using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Iterator Pattern Demo***\n");
            ISubjects ScienceSubjects = new Science();
            ISubjects ArtsSubjects = new Arts();

            IIterator IteratorForScience = ScienceSubjects.CreateIterator();
            IIterator IteratorForArts = ArtsSubjects.CreateIterator();

            Console.WriteLine("\nScience subjects:");
            Print(IteratorForScience);

            Console.WriteLine("\nArts subjects:");
            Print(IteratorForArts);
        }

        private static void Print(IIterator iterator)
        {
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next()); ;
            }
        }
    }
}
