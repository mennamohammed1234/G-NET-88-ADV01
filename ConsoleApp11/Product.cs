using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal class Container<T>
    {
        List<T> values;

        public Container() { 
            values = new List<T>();
        }
        public void Add(T item)
        {
           values.Add(item);
        }
        public T Get(int i)
        {
            return values[i];
        }
    }
}
