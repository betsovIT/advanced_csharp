using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop
{
    class Shop
    {
        private Dictionary<string, List<Laptop>> laptops;

        public Shop()
        {
            this.laptops = new Dictionary<string, List<Laptop>>();
        }

        public int Count => this.laptops.Count;
        public void AddLaptop(Laptop laptop)
        {
            IfNullThrowException(laptop);

            if (!this.laptops.ContainsKey(laptop.Make))
            {
                this.laptops.Add(laptop.Make, new List<Laptop>());
            }

            this.laptops[laptop.Make].Add(laptop);
        }

        public bool RemoveLaptop(Laptop laptop)
        {
            IfNullThrowException(laptop);

            if (!this.laptops.ContainsKey(laptop.Make))
            {
                return false;
            }

            if (!this.laptops[laptop.Make].Contains(laptop))
            {
                return false;
            }

            bool isRemoved = this.laptops[laptop.Make].Remove(laptop);

            if (this.laptops[laptop.Make].Count == 0)
            {
                isRemoved = this.laptops.Remove(laptop.Make);
            }

            return isRemoved;
        }

        public void PrintAllLaptops(Action<Laptop> laptop)
        {
            foreach (var item in collection)
            {

            }
        }

        public bool ContainsLapto(Laptop laptop)
        {
            IfNullThrowException(laptop);

            if (!this.laptops.ContainsKey(laptop.Make))
            {
                return false;
            }

            if (!this.laptops[laptop.Make].Contains(laptop))
            {
                return false;
            }

            return true;
        }

        private void IfNullThrowException(Laptop laptop)
        {
            if (laptop == null)
            {
                throw new ArgumentNullException(nameof(laptop), "Object cannot be null!");
            }
        }
    }
}
