using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    class HeroRepository
    {
        private Dictionary<string, Hero> heroes;

        public HeroRepository()
        {
            heroes = new Dictionary<string, Hero>();
        }

        public void Add(Hero hero)
        {
            heroes.Add(hero.Name, hero);
        }

        public void Remove(string name)
        {
            heroes.Remove(name);
        }

        public int Count
        {
            get
            {
                return heroes.Count;
            }
        }

        public Hero GetHeroWithHighestStrength()
        {
            return heroes.Where(n => n.Value.Item.Strength == heroes.Values.Max(p => p.Item.Strength)).FirstOrDefault().Value;
        }

        public Hero GetHeroWithHighestAbility()
        {
            return heroes.Where(n => n.Value.Item.Ability == heroes.Values.Max(p => p.Item.Ability)).FirstOrDefault().Value;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            return heroes.Where(n => n.Value.Item.Intelligence == heroes.Values.Max(p => p.Item.Intelligence)).FirstOrDefault().Value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var hero in heroes)
            {
                sb.AppendLine(hero.ToString());
            }

            return sb.ToString();
        }
    }
}
