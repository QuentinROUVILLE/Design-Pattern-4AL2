namespace ProjectDesignPattern4AL2.Classes;

public class SandwichOrdered
{
    public string Name { get; set; }
    public Dictionary<Ingredient, double> Ingredients { get; set; }
    public double Price { get; set; }

    public SandwichOrdered(Sandwich sandwich)
    {
        Name = sandwich.Name;
        Ingredients = sandwich.Ingredients;
        Price = sandwich.Price;
    }
}