using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal interface Ipreocess2<out T>
    {
        public T Get();
    }
}
