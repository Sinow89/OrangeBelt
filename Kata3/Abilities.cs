namespace Kata3;

public abstract class Abilities : IAbility
{
    public static AbilityContainer<IAbility> CreateAbility()
    {
        var abilityContainer = new AbilityContainer<IAbility>();
        abilityContainer.AddAbility(new AttackAbility("Slash Attack", "Deals 15 damage"));
        abilityContainer.AddAbility(new HealAbility("Healing Light", "Restores 20 health"));
        return abilityContainer;
    }
    
    public string Name { get; set; }
    public string Effect { get; set; }

    public override string ToString()
    {
        return $"{Name}: {Effect}";
    }
}



