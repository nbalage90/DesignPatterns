﻿using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Proxy Pattern Demo***\n");
            Proxy px = new Proxy();
            px.DoSomeWork();
        }
    }
}
