using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _070720
{
    class MyArray<T>
    {
        private T[] array;

        public MyArray()
        {
            array = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref this.array, this.array.Length + 1);

            this.array[this.array.Length - 1] = item;
        }

        public T Get(int index)
        {
            return this.array[index];
        }
    }
}
