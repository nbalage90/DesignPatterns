﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Employee : IEmployee
    {
        private string name;
        private string dept;

        public Employee(string name, string dept)
        {
            this.name = name;
            this.dept = dept;
        }

        public void PrintStructures()
        {
            Console.WriteLine($"\t\t{this.name} works in {this.dept}");
        }
    }
}
