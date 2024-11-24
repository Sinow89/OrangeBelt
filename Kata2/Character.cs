namespace Kata2;

public delegate void CharacterAction(Character target, int amount);

public class Character
{
    private int health;
    public string Name { get; private set; }
    public int Health 
    { 
        get => health;
        private set
        {
            health = value;
            HealthChanged?.Invoke(health);
        }
    }
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
    }
    
}