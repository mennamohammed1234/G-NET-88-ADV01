using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal class Classconstraint<T> where T : class
    {
        public void Add(T Item) { Console.WriteLine("Item added"); }
    }
}
