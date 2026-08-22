using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal class Safelist<T>
    {
        T[] list;
        int Capacity;
        int counter;
        public Safelist(int Capacity)
        {
            this.Capacity = Capacity;
            list= new T[Capacity];
            counter = 0;
        }
        public void Add(T item)
        {
            if (counter < list.Length){
                list[counter++] = item;
            }
        }
        public T Getbyindex(int index)
        {
            if(index>=0 & index < Capacity) return list[index];
            return default;
        }
       
        }
    }

