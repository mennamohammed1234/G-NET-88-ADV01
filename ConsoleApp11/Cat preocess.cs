using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal class Cat_preocess : Ipreocess2<Cat>
    {
        public Cat Get()
        {
          Cat cat=  new Cat();
            cat.Name = "citty";
            return cat;
        }
    }
}
