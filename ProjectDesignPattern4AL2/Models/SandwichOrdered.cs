namespace ProjectDesignPattern4AL2.Models;

public class SandwichOrdered
{
    public SandwichOrdered(Sandwich sandwich)
    {
        Name = sandwich.Name;
        Ingredients = sandwich.Ingredients;
        Price = sandwich.Price;
    }

    public string Name { get; set; }
    public Dictionary<Ingredient, double> Ingredients { get; set; }
    public double Price { get; set; }

    public override bool Equals(object obj)
    {
        var other = obj as SandwichOrdered;
        return other != null && other.Name == Name;
    }

    public override int GetHashCode()
    {
        if (Name == null) return 0;
        return Name.GetHashCode();
    }
}