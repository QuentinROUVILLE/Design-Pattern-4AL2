namespace ProjectDesignPattern4AL2.Models;

public class Ingredient
{
    public Ingredient(string name, string unit)
    {
        Name = name;
        Unit = unit;
    }

    public string Name { get; set; }
    public string Unit { get; set; }
}