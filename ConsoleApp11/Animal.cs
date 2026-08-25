using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal class Animal
    {
        public string Name {  get; set; }
        public  virtual  void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}
