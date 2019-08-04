using MXGP.Models.Riders;
using MXGP.Models.Riders.Contracts;
using MXGP.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MXGP.Repositories
{
    public class RiderRepository : IRepository<IRider>
    {
        protected List<IRider> collection;

        public RiderRepository()
        {
            this.collection = new List<IRider>();
        }
        public void Add(IRider model)
        {
            collection.Add(model);
        }

        public IReadOnlyCollection<IRider> GetAll()
        {
            return new ReadOnlyCollection<IRider>(collection);
        }

        public IRider GetByName(string name)
        {
            return collection.FirstOrDefault(c => c.Name == name);
        }

        public bool Remove(IRider model)
        {
            return collection.Remove(model);
        }
    }
}
