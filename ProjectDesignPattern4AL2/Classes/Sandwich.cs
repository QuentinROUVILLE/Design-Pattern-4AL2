namespace ProjectDesignPattern4AL2.Classes;

public class Sandwich
{
    public string Name { get; set; }
    public Dictionary<Ingredient, int> Ingredients { get; set; }
    public double Price { get; set; }

    public Sandwich(string name, Dictionary<Ingredient, int> ingredients, double price)
    {
        Name = name;
        Ingredients = ingredients;
        Price = price;
    }
}