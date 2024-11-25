namespace Kata3;

public class AttackAbility : Abilities, IAbility
{
    public AttackAbility(string name, string effect)
    {
        Name = name;
        Effect = effect;
    }
}