using Heroes.Aura;
using Heroes.Shield;

namespace Heroes
{
    public class Druid : BaseHero, ICastShield, ICastAura
    {
        public Druid(string name) : base(name)
        {
            Health = 200;
            SpellPower = 80;
        }

        public override void CastAbility(BaseHero target)
        {
            target.Health += SpellPower;
            Console.WriteLine($"Druid {Name} healed {target.Name} with {SpellPower} health.");
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
            else if (target.Health <= 0)
            {
                Console.WriteLine($"Hero {target.Name} died!");
            }
        }

        public void CastAura()
        {
            var oldAbilityPower = SpellPower;
            SpellPower = (int)(SpellPower * 1.05);
            Console.WriteLine($"{Name} casted an aura and increased ability power to {oldAbilityPower + 5}%!");
        }

        public void CastShield()
        {
            var oldHealth = Health;
            Health = (int)(Health * 1.1);
            Console.WriteLine($"{Name} casted a shield and increased health to {oldHealth + 10}%!");
        }
    }
}
