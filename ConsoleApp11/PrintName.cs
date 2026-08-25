using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal class PrintName<T> where T:Iname
    {
        public void printName( T b)
        {
            b.getname();
        }
    }
}
