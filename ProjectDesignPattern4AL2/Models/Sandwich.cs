namespace ProjectDesignPattern4AL2.Classes;

public class Sandwich
{
    public string Name { get; set; }
    public Dictionary<Ingredient, double> Ingredients { get; set; }
    public double Price { get; set; }

    public Sandwich(string name, Dictionary<Ingredient, double> ingredients, double price)
    {
        Name = name;
        Ingredients = ingredients;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - {Price}€";
    }
}