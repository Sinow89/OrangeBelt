namespace Kata3;

public class Combat
{
    public class AbilityContainer<T>
    {
        private List<T> abilities = new List<T>();

        public void AddAbility(T ability)
        {
            abilities.Add(ability);
        }

        public IEnumerable<T> GetAbilities()
        {
            return abilities;
        }
    }
}

public class AttackAbility : IAbility
{
    public string Name { get; set; }
    public string Effect { get; set; }

    public AttackAbility(string name, string effect)
    {
        Name = name;
        Effect = effect;
    }
}

public class HealAbility : IAbility
{
    public string Name { get; set; }
    public string Effect { get; set; }

    public HealAbility(string name, string effect)
    {
        Name = name;
        Effect = effect;
    }
}