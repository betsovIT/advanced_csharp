using MXGP.Models.Races;
using MXGP.Models.Races.Contracts;
using MXGP.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MXGP.Repositories
{
    public class RaceRepository : IRepository<IRace>
    {
        protected List<IRace> collection;

        public RaceRepository()
        {
            this.collection = new List<IRace>();
        }
        public void Add(IRace model)
        {
            collection.Add(model);
        }

        public IReadOnlyCollection<IRace> GetAll()
        {
            return new ReadOnlyCollection<IRace>(collection);
        }

        public IRace GetByName(string name)
        {
            return collection.FirstOrDefault(r => r.Name == name);
        }

        public bool Remove(IRace model)
        {
            return collection.Remove(model);
        }
    }
}