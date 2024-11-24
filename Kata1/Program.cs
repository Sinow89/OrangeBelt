using System.Security.Authentication;

namespace Kata1;

class Program
{
    static void Main()
    {
        Character Warrior = new ("Nisse", "Warrior", 49, 10, primaryAction: () => {Console.WriteLine("Attacking");});
        Character Healer = new ("Kalle", "Healer", 45, 10,primaryAction: () => {Console.WriteLine("Attacking");});

        List<Character> characters = new List<Character> { Warrior, Healer };
        
        var lowHealthCharacters = characters.Where(character => character.Health < 50).ToList();
        foreach (var character in lowHealthCharacters)
        {
            Console.WriteLine($"{character.Name} is attacking first due to low health!");
            character.PrimaryAction();
            Warrior.Attack();
            Healer.Heal(character);
        }
        Console.WriteLine();
    }
}