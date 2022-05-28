namespace ProjectDesignPattern4AL2.Models;

public class Sandwich
{
    public Sandwich(string name, Dictionary<Ingredient, double> ingredients, double price)
    {
        Name = name;
        Ingredients = ingredients;
        Price = price;
    }

    public string Name { get; set; }
    public Dictionary<Ingredient, double> Ingredients { get; set; }
    public double Price { get; set; }
}