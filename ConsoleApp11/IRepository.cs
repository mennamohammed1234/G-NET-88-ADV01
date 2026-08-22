using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal interface IRepository<T>
    {
        T Create();
        T GetPyID(int id);
        T[] GetALL();

    }
}
