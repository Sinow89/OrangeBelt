namespace Kata3;

public abstract class Abilities
{
    public static AbilityContainer<Abilities> CreateAbility()
    {
        var abilityContainer = new AbilityContainer<Abilities>();
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



