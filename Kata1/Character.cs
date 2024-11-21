using System.Security.Cryptography;

namespace Kata1;

public  class Character
{
    public string Name { get; private set; }
    public string Type { get; private set; }
    public int Health { get; private set; }
    public int Damage { get; private set; }
    public Action PrimaryAction { get;  set; }
    
    public Character(string name, string type, int health, int damage, Action primaryAction)
    {
        Name = name;
        Type = type;
        Health = health;
        Damage = damage;
        PrimaryAction = primaryAction;
    }
    
    public void Attack()
    {
        Console.WriteLine($"{Name} attacks Orc ");
    }
    
    public void Heal(Character character)
    {
        Console.WriteLine($"{Name} heals {character.Name} ");
    }
    
}