using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal class AnimalPreocess : Iprocessor<Animal>
    {
        public void Process(Animal animal)
        {
            Console.WriteLine($"Process {animal.Name}");
        }

    }
}
