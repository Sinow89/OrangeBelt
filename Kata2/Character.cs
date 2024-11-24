namespace Kata2;

public class Character
{

    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Damage { get; private set; }

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }
    
    public delegate void CharacterAction(Character target, int amount);
    
    public event Action<int> HealthChanged;
    
    
    
    
    public void Attack(Character target, int damage)
    {
        target.Health = Health - damage;
        Console.WriteLine($"{Name} attacked {target.Name} with {damage}.");
    }
    
}