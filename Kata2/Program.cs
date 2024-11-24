namespace Kata2;

class Program
{
    static void Main()
    {
        var arin = new Character("Arin", 120);
        var dalia = new Character("Dalia", 100);
        
        arin.HealthChanged += OnHealthChanged;
        dalia.HealthChanged += OnHealthChanged;
        
        void OnHealthChanged(Character character, int newHealth)
        {
            Console.WriteLine($"[Event] {character.Name}'s health changed to {newHealth}.");
        }
        
        arin.Attack(dalia, 10);
        dalia.Attack(arin, 15);
        
    }
}