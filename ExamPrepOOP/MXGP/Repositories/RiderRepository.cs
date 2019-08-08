﻿using MXGP.Models.Riders.Contracts;
using MXGP.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXGP.Repositories
{
    public class RiderRepository : IRepository<IRider>
    {
        private List<IRider> riders;

        public RiderRepository()
        {
            riders = new List<IRider>();
        }

        public void Add(IRider model)
        {
            if (model != null)
            {
                riders.Add(model);
            }
        }

        public IReadOnlyCollection<IRider> GetAll()
        {
            return riders.AsReadOnly();
        }

        public IRider GetByName(string name)
        {
            return riders.FirstOrDefault(r => r.Name == name);
        }

        public bool Remove(IRider model)
        {
            return riders.Remove(model);
        }
    }
}
