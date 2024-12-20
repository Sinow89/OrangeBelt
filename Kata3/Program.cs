﻿using System.Runtime.CompilerServices;

namespace Kata3;

class Program
{
    static void Main()
    {
        var abilityContainer = new AbilityContainer<IAbility>();
        
        var slashAttack = new AttackAbility("Slash Attack", "Deals 15 damage");
        var healingLight = new HealAbility("Healing Light", "Restores 20 health");
        
        AddAbilities(new()
        {
            slashAttack,
            healingLight
        });
        Display();
        
        void AddAbilities(List<IAbility> abilities)
        {
            Console.WriteLine("Adding abilities to the container...");
            foreach (var ability in abilities)
            {
                abilityContainer.AddAbility(ability);
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