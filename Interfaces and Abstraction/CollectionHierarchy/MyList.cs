using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    class MyList : IMyList
    {
        private List<string> internalCollection;
        public int Used { get => internalCollection.Count; }


        public MyList()
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
            string temp = internalCollection[0];
            internalCollection.RemoveAt(0);
            return temp;
        }
    }
}
