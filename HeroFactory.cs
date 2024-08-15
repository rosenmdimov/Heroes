using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    public class HeroFactory
    {
        public static BaseHero CreateHero(string name, string heroType)
        {
            switch (heroType.ToLower())
            {
                case "druid":
                    return new Druid(name);
                case "paladin":
                    return new Paladin(name);
                case "rogue": 
                    return new Rogue(name);
                case "warrior": 
                    return new Warrior(name);
                default:
                    return null;
            }
        }
    }
}
