using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;
        private int currentIndex = 0;

        public ListyIterator()
        {
            this.collection = new List<T>();
        }

        public void Create(List<T> items)
        {
            if (items.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            else
            {
                this.collection = new List<T>(items);
            }
        }

        public bool Move()
        {
            if (currentIndex + 1 < collection.Count)
            {
                currentIndex++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (collection.Count > 0)
            {
                Console.WriteLine(collection[currentIndex]);
            }
        }

        public bool HasNext()
        {
            if (true)
            {
                if (currentIndex + 1 < collection.Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.collection.Count; i++)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < this.collection.Count; i++)
            {
                yield return this.collection[i];
            }
        }        
    }
}
