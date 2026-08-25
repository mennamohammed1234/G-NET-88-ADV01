using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsoleApp11
{
    internal class Multiconstrain<T>where T : class,new()
    {
    public T Get()
        {
            return new T();
        }
    }
}
