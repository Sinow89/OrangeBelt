namespace Kata3;

public class HealAbility : Abilities, IAbility
{
    public HealAbility(string name, string effect)
    {
        Name = name;
        Effect = effect;
    }
}