namespace ProjectDesignPattern4AL2.Models;

public class Bill
{
    public Bill(Dictionary<SandwichOrdered, List<string>> sandwiches)
    {
        Sandwiches = sandwiches;
    }
    
    public Dictionary<SandwichOrdered, List<string>> Sandwiches { get; set; }

    public double calculateBill()
    {
        double totalPrice = 0;
        foreach (KeyValuePair<SandwichOrdered, List<string>> sandwich in Sandwiches)
        {
            totalPrice += sandwich.Key.Price * sandwich.Value.Count;
        }
        return totalPrice;
    }
}