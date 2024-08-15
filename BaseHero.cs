
namespace Heroes
{
    public abstract class BaseHero
    {
        public string Name { get; set; }
        public int Health { get; set; } = 120;
        public int SpellPower { get; set; } = 90;

        public abstract void CastAbility(BaseHero target);

        protected BaseHero(string name)
        {
            Name = name;
        }

        private static bool _isInstantiated = false;
        static BaseHero()
        {
            if (_isInstantiated)
            {
                throw new InvalidOperationException("BaseHero cannot be instantiated");
            }
            _isInstantiated = true;
        }
    }
}
