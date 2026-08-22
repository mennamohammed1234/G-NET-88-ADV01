using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp11
{
    internal class StructConstraint<T> where T : struct
    {
        T v1;
        T v2;
        public StructConstraint(T v1,T v2) { this.v1 = v1; this.v2 = v2; }
        public override string ToString()
        {
             return  $"value1: {v1} value2: {v2}"; 
        }
    }
}
