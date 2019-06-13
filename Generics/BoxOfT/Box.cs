using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> collection;

        public int Count
        {
            get
            {
                return collection.Count;
            }
        }

        public Box()
        {
            collection = new Stack<T>();
        }

        public void Add(T element)
        {
            collection.Push(element);
        }

        public T Remove()
        {
            return collection.Pop();
        }
    }
}
