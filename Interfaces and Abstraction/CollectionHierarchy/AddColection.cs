using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    class AddColection : IAddCollection
    {
        private List<string> internanlCollection;

        public AddColection()
        {
            internanlCollection = new List<string>();
        }

        public int Add(string element)
        {
            internanlCollection.Add(element);

            return internanlCollection.Count - 1;
        }
    }
}
