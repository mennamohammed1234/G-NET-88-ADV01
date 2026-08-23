using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal class AnimalSound<T> where T : Animal
    {

        public void MakeSound(T animal)
        {
            animal.Sound();
        }
    }
}
