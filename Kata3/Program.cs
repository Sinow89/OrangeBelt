﻿namespace Kata3;

/*
 Expected Output:
 
 *Adding abilities to the container...
- Added Attack: Slash Attack (Effect: Deals 15 damage)
- Added Heal: Healing Light (Effect: Restores 20 health)

Executing abilities...
- Using Slash Attack on Enemy. Enemy health is now 85.
- Using Healing Light on Ally. Ally health is now 120.

Listing all abilities in the container:
- Slash Attack (Effect: Deals 15 damage)
- Healing Light (Effect: Restores 20 health)

 */

class Program
{
    static void Main()
    {
       var abilityContainer = new AbilityContainer<Abilities>();
       
       abilityContainer.AddAbility(new AttackAbility("Fireball", "Deals 50 damage"));
       abilityContainer.AddAbility(new HealAbility("Heal", "Restores 30 HP"));
       
       foreach (var ability in abilityContainer.GetAbilities())
       {
           Console.WriteLine(ability);
       }
       
       
    }
}