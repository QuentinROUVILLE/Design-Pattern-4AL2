using ProjectDesignPattern4AL2.Classes;

namespace ProjectDesignPattern4AL2.Storage;

public class InMemorySandwich
{
    private readonly List<Sandwich> _sandwiches;

    public void Add(Sandwich sandwich)
    {
        _sandwiches.Add(sandwich);
    }

    public Sandwich? Get(string name)
    {
        return _sandwiches.FirstOrDefault(s => s.Name == name);
    }
}