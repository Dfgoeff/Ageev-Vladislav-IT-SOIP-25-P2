using System;
using System.Collections.Generic;
using System.Text;

namespace KT_1
{
    internal class Box<T>
    {
        private T item;

        public void Put(T item)
        {
            this.item = item;
        }
        public T Get()
        {
            return this.item;
        }
    }
}
