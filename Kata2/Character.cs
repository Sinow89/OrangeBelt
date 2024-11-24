namespace Kata2;

public delegate void CharacterAction(Character target, int amount);

public class Character
{
    public int Health { get; private set; }
    public string Name { get; private set; }
   
    private CharacterAction attackAction;
    public Character(string name, int health)
    {
        Name = name;
        Health = health;
        attackAction = (target, damage) =>
        {
            Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage.");
            Health -= damage;
        };
    }
    
    public event Action<int> HealthChanged;
    
    public void Attack(Character target, int damage)
    {
        attackAction(target, damage);
        HealthChanged?.Invoke(Health);
    }
}