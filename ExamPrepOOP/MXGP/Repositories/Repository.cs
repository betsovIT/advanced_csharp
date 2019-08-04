using MXGP.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MXGP.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        protected List<T> collection;

        public Repository()
        {
            this.collection = new List<T>();
        }
        public void Add(T model)
        {
            collection.Add(model);
        }

        public IReadOnlyCollection<T> GetAll()
        {
            return new ReadOnlyCollection<T>(collection);
        }

        public virtual T GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T model)
        {
            return collection.Remove(model);
        }
    }
}
