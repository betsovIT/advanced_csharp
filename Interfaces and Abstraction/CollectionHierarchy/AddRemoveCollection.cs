using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    class AddRemoveCollection : IAddRemoveCollection
    {
        private List<string> internalCollection;

        public AddRemoveCollection()
        {
            internalCollection = new List<string>();
        }
        public int Add(string element)
        {
            internalCollection.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            string temp = internalCollection[internalCollection.Count - 1];
            internalCollection.RemoveAt(internalCollection.Count - 1);
            return temp;
        }
    }
}
