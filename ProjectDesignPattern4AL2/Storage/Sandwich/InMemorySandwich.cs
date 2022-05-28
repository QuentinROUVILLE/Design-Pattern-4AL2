namespace ProjectDesignPattern4AL2.Storage.Sandwich;

public class InMemorySandwich : ISandwiches
{
    private static readonly Dictionary<Classes.Sandwich, int> Sandwiches = new Dictionary<Classes.Sandwich, int>();

    public void Add(Classes.Sandwich sandwich, int quantity)
    {
        if(GetSandwich(sandwich.Name) == null)
        {
            Sandwiches.Add(sandwich, quantity);
        }
        else
        {
            Sandwiches[sandwich] += quantity;
        }
    }

    public Classes.Sandwich? GetSandwich(string name)
    {
        return Sandwiches.FirstOrDefault(s => s.Key.Name == name).Key;
    }

    public int? GetStock(string name)
    {
        return Sandwiches.FirstOrDefault(s => s.Key.Name == name).Value;
    }

    public void BuySandwiches(Dictionary<Classes.SandwichOrdered, int> sandwiches)
    {
        foreach (var sandwich in sandwiches)
        {
            if(GetStock(sandwich.Key.Name) < sandwich.Value)
            {
                throw new Exception("Il n'y a pas assez de " + sandwich.Key.Name + " en stock (en stock : " + GetStock(sandwich.Key.Name) + ")");
            }
            {
                Sandwiches[GetSandwich(sandwich.Key.Name)!] -= sandwich.Value;
            }
        }
    }
}