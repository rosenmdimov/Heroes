using Heroes.Aura;
using Heroes.Shield;

namespace Heroes
{
    public class Rogue : BaseHero, ICastAura, ICastShield
    {
        public Rogue(string name) : base(name)
        {
            Health = 230;
        }

        public override void CastAbility(BaseHero target)
        {
            target.Health -= SpellPower;
            Console.WriteLine($"Rogue {Name} hit {target.Name} for {SpellPower} damage.");
            if(target.Health <= 0)
            {
                Console.WriteLine("Hero {target.Name} died!");
            }
            else if (target.Health <= 10)
            {
                Console.WriteLine($"Hero {target.Name} is low health! Need a healer ASAP!");
            }
        }

        void ICastAura.CastAura()
        {
            var oldAbilityPower = SpellPower;
            SpellPower = (int)(SpellPower * 1.1);
            Console.WriteLine($"{Name} casted an aura and increased ability power to {oldAbilityPower + 10}%!");
        }

        void ICastShield.CastShield()
        {
            var oldHealth = Health;
            Health = (int)(Health * 1.02);
            Console.WriteLine($"{Name} casted a shield and increased health to {oldHealth + 2}%!");
        }
    }
}
