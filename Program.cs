using Heroes;
using Heroes.Aura;
using Heroes.Shield;

class Program
{
 
        static void Main(string[] args)
    {
        var heroes = new List<BaseHero>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(' ');
            var name = input[2];
            var heroType = input[0];

            var hero = HeroFactory.CreateHero(name, heroType);

            if (hero == null)
            {
                Console.WriteLine("Invalid hero!");
                continue;
            }

            if (heroes.Any(h => h.Name == name))
            {
                Console.WriteLine("That hero already exists!");
                continue;
            }

            heroes.Add(hero);
        }

        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            var input = Console.ReadLine().Split(' ');
            var heroName = input[0];
            var action = input[1];
            var targetHeroName = input.Length > 2 ? input[2] : string.Empty;

            var hero = heroes.FirstOrDefault(h => h.Name == heroName);
            var targetHero = heroes.FirstOrDefault(h => h.Name == targetHeroName);

            if (hero == null)
            {
                Console.WriteLine($"Hero {heroName} not found!");
                continue;
            }

            if (targetHero == null && action != "aura" && action != "shield")
            {
                Console.WriteLine($"Target hero {targetHeroName} not found!");
                continue;
            }

            switch (action)
            {
                case "aura":
                    ((ICastAura)hero).CastAura();
                    break;
                case "shield":
                    ((ICastShield)hero).CastShield();
                    break;
                default:
                    hero.CastAbility(targetHero);
                    break;
            }
        }
    }

}