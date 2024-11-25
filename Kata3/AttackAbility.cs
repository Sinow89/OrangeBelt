﻿namespace Kata3;

public class AttackAbility : IAbility
{
    public string Name { get; set; }
    public string Effect { get; set; }

    public AttackAbility(string name, string effect)
    {
        Name = name;
        Effect = effect;
    }
}