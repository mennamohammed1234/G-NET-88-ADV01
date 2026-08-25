using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal interface Iprocessor<in T>
    {
        public void Process(T obj);

    }
}
