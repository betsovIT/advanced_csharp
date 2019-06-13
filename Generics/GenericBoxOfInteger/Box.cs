using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        private T entity;

        public Box(T entity)
        {
            this.entity = entity;
        }


        public override string ToString()
        {
            return $"{entity.GetType()}: {entity}";
        }
    }
}
