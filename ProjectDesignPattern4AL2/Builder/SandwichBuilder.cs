using ProjectDesignPattern4AL2.Models;

namespace ProjectDesignPattern4AL2.Builder;

public class SandwichBuilder : ISandwichBuilder
{
  
    private string Name { get; set; }
    private Dictionary<Ingredient, double> Ingredients { get; set; }
    
    private double Price { get; set; }

    public SandwichBuilder()
    {
        Ingredients = new Dictionary<Ingredient, double>();
        Name = "";
        Price = 0;
    }

    public void Reset()
    {
        Ingredients = new Dictionary<Ingredient, double>();
        Name = "";
        Price = 0;
    }

    public SandwichBuilder BuildJambonBeurre()
    {
        Reset();
        Name = "Jambon-Beurre";
        Ingredients.Add(new Ingredient("Pain", "unité"),1);
        Ingredients.Add(new Ingredient("Jambon", "tranche"),1);
        Ingredients.Add(new Ingredient("Beurre", "gramme"),1);
        Price = 2.5;
        return this;
    }

    
    
    public SandwichBuilder BuildPouletCrudites()
    {
        Reset();
        Name = "Poulet-Crudites";
        Ingredients.Add(new Ingredient("Pain", "unité"),1);
        Ingredients.Add(new Ingredient("Poulet", "tranche"),1);
        Ingredients.Add(new Ingredient("Crudite", "gramme"),1);
        Price = 4.5;
        return this;
    }
    
    
    public SandwichBuilder BuildDieppois()
    {
        Reset();
        Name = "Dieppois";
        Ingredients.Add(new Ingredient("Pain", "unité"),1);
        Ingredients.Add(new Ingredient("Dieppois", "tranche"),1);
        Price = 3.5;
        return this;
    }

    public Sandwich BuildSandwich()
    {
        return new Sandwich(Name, Ingredients, Price);
    }
}