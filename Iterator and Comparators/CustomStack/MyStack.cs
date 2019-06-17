using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class MyStack<T> : IEnumerable<T>
    {
        private List<T> collection;

        public MyStack()
        {
            this.collection = new List<T>();
        }

        public void Push(T element)
        {
            collection.Add(element);
        }
        public void Pop()
        {
            if (collection.Count>0)
            {
                collection.RemoveAt(collection.Count - 1);
            }
            else
            {
                throw new InvalidOperationException("No elements");
            }
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                yield return collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                yield return collection[i];
            }
        }
    }
}
