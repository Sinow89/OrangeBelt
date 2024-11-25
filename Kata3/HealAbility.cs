namespace Kata3;

public class HealAbility : IAbility
{
    public string Name { get; }
    public string Effect { get; }
    public HealAbility(string name, string effect)
    {
        Name = name;
        Effect = effect;
    }
}