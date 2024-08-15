using Heroes.Aura;
using Heroes.Shield;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    public class Warrior : BaseHero, ICastAura, ICastShield
    {
        public Warrior(string name) : base(name)
        {
            SpellPower = 120;
        }

        public override void CastAbility(BaseHero target)
        {
            target.Health -= SpellPower;
            Console.WriteLine($"Warrior {Name} hit {target.Name} for {SpellPower} damage.");
            if (target.Health <= 0)
            {
                Console.WriteLine($"Hero {target.Name} died!");
            }
            else if (target.Health <= 10) 
            {
                Console.WriteLine($"Hero {target.Name} is low health! Need a healer ASAP!");
            }
        }

        public void CastAura()
        {
            int oldAbilityPower = SpellPower;
            SpellPower = (int)(SpellPower * 1.05);
            Console.WriteLine($"{Name} casted an aura and increased ability power to {oldAbilityPower + 5}%!");
        }

        public void CastShield()
        {
            int oldHealth = Health;
            Health = (int)(Health * 1.05);
            Console.WriteLine($"{Name} casted a shield and increased health to {oldHealth + 5}%!");
}
    }
}
