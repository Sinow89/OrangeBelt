namespace Kata3;

public class View : Abilities
{
    private AbilityContainer<Abilities> abilityContainer;

    public View()
    {
        abilityContainer = Abilities.CreateAbility();
    }
    public void Show()
    {
        
        foreach (var ability in abilityContainer.GetAbilities())
        {
            Console.WriteLine(ability);
        }
    }
}