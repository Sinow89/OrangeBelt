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
        var arin = new Character("Arin", 100);
        var dalia = new Character("Dalia", 120);
        
        arin.HealthChanged += (newHealth) => 
            Console.WriteLine($"[Event] {arin.Name}'s health changed to {newHealth}.\n");
        
        dalia.HealthChanged += (newHealth) => 
            Console.WriteLine($"[Event] {dalia.Name}'s health changed to {newHealth}.\n");
        
        arin.Attack(dalia, 10);
        dalia.Attack(arin, 15);
        
    }
}