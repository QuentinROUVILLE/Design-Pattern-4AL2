namespace ProjectDesignPattern4AL2.Models;

public class Ingredient
{
    public string Name { get; set; }
    public string Unit { get; set; }
    
    public Ingredient(string name, string unit)
    {
        Name = name;
        Unit = unit;
    }
    
    public override string ToString()
    {
        return $"{Name} {Unit}";
    }
}