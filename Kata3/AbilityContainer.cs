namespace Kata3;

public class AbilityContainer<T>
{
    private List<T> abilities = new List<T>();

    public void AddAbility(T ability)
    {
        abilities.Add(ability);
    }
    
    public void RemoveAbility(T ability)
    {
        abilities.Remove(ability);
    }

    public IEnumerable<T> GetAbilities()
    {
        return abilities;
    }
    
}