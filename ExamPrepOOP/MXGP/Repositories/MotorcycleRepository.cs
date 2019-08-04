using MXGP.Models.Motorcycles;
using MXGP.Models.Motorcycles.Contracts;
using MXGP.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MXGP.Repositories
{
    public class MotorcycleRepository : IRepository<IMotorcycle>
    {
        protected List<IMotorcycle> collection;

        public MotorcycleRepository()
        {
            this.collection = new List<IMotorcycle>();
        }
        public void Add(IMotorcycle model)
        {
            collection.Add(model);
        }

        public IReadOnlyCollection<IMotorcycle> GetAll()
        {
            return new ReadOnlyCollection<IMotorcycle>(collection);
        }

        public IMotorcycle GetByName(string name)
        {
            return collection.FirstOrDefault(c => c.Model == name);
        }

        public bool Remove(IMotorcycle model)
        {
            return collection.Remove(model);
        }
    }
}
