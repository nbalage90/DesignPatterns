using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private int numberOfInstance = 0;

        private Singleton()
        {
            Console.WriteLine("Instantiating inside the private constructor");
            numberOfInstance++;
            Console.WriteLine("Number or instances = {0}", numberOfInstance);
        }

        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("We already have an instance now. Use it");
                return instance;
            }
        }
    }
}
