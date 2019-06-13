using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodString
{
    public class GenericList<T> where T : IComparable
    {
        private List<T> internalList;

        public GenericList()
        {
            internalList = new List<T>();
        }
        public void Add(T element)
        {
            internalList.Add(element);
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            T temp = internalList[firstIndex];
            internalList[firstIndex] = internalList[secondIndex];
            internalList[secondIndex] = temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in internalList)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString();
        }

        public int GetCountOfGreaterElements(T element)
        {
            int greaterElements = 0;
            foreach (var item in internalList)
            {
                if (item.CompareTo(element) > 0)
                {
                    greaterElements++;
                }
            }

            return greaterElements;
        }
    }
}
