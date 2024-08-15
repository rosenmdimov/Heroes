using Heroes.Aura;
using Heroes.Shield;

namespace Heroes
{
    public class Paladin : BaseHero, ICastAura, ICastShield
    {
        public Paladin(string name) : base(name)
        {
            Health = 240;
            SpellPower = 100;
        }

        public override void CastAbility(BaseHero target)
        {
            target.Health += SpellPower;
            Console.WriteLine($"Paladin {Name} healed {target.Name} with {SpellPower} health.");
            if (target.Health >= target.Health)
            {
                Console.WriteLine($"Hero {target.Name} was fully healed!");
            }
            else if (target.Health > target.Health)
            {
                var healthDifference = Math.Min(target.Health - target.Health, target.Health);
                Console.WriteLine($"Hero {target.Name} was overhealed with {healthDifference} health!");
            }
            else if (target.Health <= 10)
            {
                Console.WriteLine($"Hero {target.Name} is low health! Need a healer ASAP!");
            }
            else if(target.Health <= 0)
            {
                Console.WriteLine($"Hero {target.Name} died!");
            }
        }

        public void CastAura()
        {
            var oldAbilityPower = SpellPower;
            SpellPower = (int)(SpellPower * 1.15);
            Console.WriteLine($"{Name} casted an aura and increased ability power to {oldAbilityPower + 15}%!");
        }

        public void CastShield()
        {
            var oldHealth = Health;
            Health = (int)(Health * 1.12);
            Console.WriteLine($"{Name} casted a shield and increased health to {oldHealth + 12}%!");
        }
    }
}
