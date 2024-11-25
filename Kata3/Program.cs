namespace Kata3;

class Program
{
    static void Main()
    {
        var abilityContainer = new AbilityContainer<IAbility>();
        abilityContainer.AddAbility(new AttackAbility("Slash Attack", "Deals 15 damage"));
        abilityContainer.AddAbility(new HealAbility("Healing Light", "Restores 20 health"));
        Adding();
        Display();
        
        void Adding()
        {
            Console.WriteLine("Adding abilities to the container...");
            foreach (var ability in abilityContainer.GetAbilities())
            {
                Console.WriteLine($"Added Attack: {ability.Name} (Effects: {ability.Effect})");
            }
            Console.WriteLine();
        }
        
        void Display()
        {
            Console.WriteLine("Listing all abilities in the container:");
            foreach (var ability in abilityContainer.GetAbilities())
            {
                Console.WriteLine($"{ability.Name} {ability.Effect}");
            }
        }
        return;
    }
}