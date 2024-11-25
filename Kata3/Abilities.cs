namespace Kata3;

public abstract class Abilities
{
    public string Name { get; set; }
    public string Effect { get; set; }

    public override string ToString()
    {
        return $"{Name}: {Effect}";
    }
}



