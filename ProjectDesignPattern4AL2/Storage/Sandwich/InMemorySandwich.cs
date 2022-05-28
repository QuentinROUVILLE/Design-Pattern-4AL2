using ProjectDesignPattern4AL2.Models;

namespace ProjectDesignPattern4AL2.Storage.Sandwich;

public class InMemorySandwich : ISandwiches
{
    private static readonly Dictionary<Models.Sandwich, int> Sandwiches = new();

    public void Add(Models.Sandwich sandwich, int quantity)
    {
        if (GetSandwich(sandwich.Name) == null)
            Sandwiches.Add(sandwich, quantity);
        else
            Sandwiches[sandwich] += quantity;
    }

    public Models.Sandwich? GetSandwich(string name)
    {
        return Sandwiches.FirstOrDefault(s => s.Key.Name == name).Key;
    }

    public int? GetStock(string name)
    {
        return Sandwiches.FirstOrDefault(s => s.Key.Name == name).Value;
    }

    public void BuySandwiches(Dictionary<SandwichOrdered, List<string>> sandwiches)
    {
        foreach (var sandwich in sandwiches)
        {
            if (GetStock(sandwich.Key.Name) < sandwich.Value.Count)
                throw new Exception("Il n'y a pas assez de " + sandwich.Key.Name + " en stock (en stock : " +
                                    GetStock(sandwich.Key.Name) + ")");
            Sandwiches[GetSandwich(sandwich.Key.Name)!] -= sandwich.Value.Count;
        }
    }
}