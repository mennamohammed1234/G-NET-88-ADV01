using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal class Pair<T1,T2>
    {
       public T1 Key {  get; set; }
       public T2 Value { get; set; }
        public Pair(T1 key, T2 value)
        {
            Key = key;
            Value = value;
        }
        public override string ToString()
        {
            return $"key: {Key} Value: {Value}";
        }

    }
}
