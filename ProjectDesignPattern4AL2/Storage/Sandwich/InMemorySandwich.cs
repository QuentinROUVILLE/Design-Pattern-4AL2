namespace ProjectDesignPattern4AL2.Storage.Sandwich;

public class InMemorySandwich : ISandwiches
{
    private static readonly List<Classes.Sandwich> _sandwiches;

    public void Add(Classes.Sandwich sandwich)
    {
        _sandwiches.Add(sandwich);
    }

    public Classes.Sandwich? Get(string name)
    {
        return _sandwiches.FirstOrDefault(s => s.Name == name);
    }
}