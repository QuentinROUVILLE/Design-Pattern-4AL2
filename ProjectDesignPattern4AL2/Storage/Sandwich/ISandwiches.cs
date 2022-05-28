using ProjectDesignPattern4AL2.Models;

namespace ProjectDesignPattern4AL2.Storage.Sandwich;

public interface ISandwiches
{
    void Add(Models.Sandwich command, int quantity);

    Models.Sandwich? GetSandwich(string name);

    public int? GetStock(string name);

    void BuySandwiches(Dictionary<SandwichOrdered, List<string>> sandwiches);
}