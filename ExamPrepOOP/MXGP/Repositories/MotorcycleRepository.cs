using MXGP.Models.Motorcycles.Contracts;
using MXGP.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXGP.Repositories
{
    public class MotorcycleRepository : IRepository<IMotorcycle>
    {
        private List<IMotorcycle> motorcycles;

        public MotorcycleRepository()
        {
            this.motorcycles = new List<IMotorcycle>();
        }

        public void Add(IMotorcycle model)
        {
            if (model != null)
            {
                motorcycles.Add(model);
            }
        }

        public IReadOnlyCollection<IMotorcycle> GetAll()
        {
            return motorcycles.AsReadOnly();
        }

        public IMotorcycle GetByName(string name)
        {
            return motorcycles.FirstOrDefault(m => m.Model == name);
        }

        public bool Remove(IMotorcycle model)
        {
            return motorcycles.Remove(model);
        }
    }
}
