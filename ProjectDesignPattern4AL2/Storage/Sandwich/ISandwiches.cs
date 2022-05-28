namespace ProjectDesignPattern4AL2.Storage.Sandwich;

public interface ISandwiches
{
    void Add(Classes.Sandwich command, int quantity);
    
    Classes.Sandwich? GetSandwich(string name);

    public int? GetStock(string name);
    
    void BuySandwiches(Dictionary<Classes.Sandwich, int> sandwiches);
}