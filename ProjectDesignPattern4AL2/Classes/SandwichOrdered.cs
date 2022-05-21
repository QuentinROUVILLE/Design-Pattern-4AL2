namespace ProjectDesignPattern4AL2.Classes;

public class SandwichOrdered
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Dictionary<Ingredient, int> Ingredients { get; set; }
    public double Price { get; set; }

    public SandwichOrdered(int id, Sandwich sandwich)
    {
        Id = id;
        Name = sandwich.Name;
        Ingredients = sandwich.Ingredients;
        Price = sandwich.Price;
    }
}