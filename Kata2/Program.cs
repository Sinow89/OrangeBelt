namespace Kata2;

/* Arin attacks Dalia for 10 damage.
[Event] Dalia's health changed to 90.

Dalia heals herself for 15 health.
[Event] Dalia's health changed to 105.

Arin performs a special action!
[Event] Arin's special action was performed.
*/

class Program
{
    static void Main()
    {
        var character = new Character("Arin", 100);
        var character2 = new Character("Dalia", 100);
        character.Attack(character2, 50);
        
        
        
        character.HealthChanged += OnHealthChanged;
        void OnHealthChanged(int newHealth)
        {
            Console.WriteLine($"[Event] Character's health changed to {newHealth}.");
        }

        
    }
}