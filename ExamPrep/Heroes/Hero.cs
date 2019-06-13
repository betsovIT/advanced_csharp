using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    class Hero
    {
        private string name;
        private int level;
        private Item item;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
            }
        }

        public Item Item
        {
            get
            {
                return this.item;
            }
            set
            {
                this.item = value;
            }
        }

        public Hero(string name,int level, Item item)
        {
            this.name = name;
            this.level = level;
            this.item = item;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Hero: {this.name} - {this.level}lvl");
            sb.AppendLine(this.item.ToString());

            return sb.ToString();
        }
    }
}
