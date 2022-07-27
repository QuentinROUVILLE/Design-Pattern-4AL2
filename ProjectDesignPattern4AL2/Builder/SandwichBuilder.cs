using ProjectDesignPattern4AL2.Models;

namespace ProjectDesignPattern4AL2.Builder;

public class SandwichBuilder: IBuilder
{

    public Dictionary<Ingredient, double> Ingredients { get; set; }
    
    public double Price { get; set; }
    
    private Sandwich Sandwich { get; set; }


    public SandwichBuilder()
    {
        Sandwich = new Sandwich();
    }

    public void Reset()
    {
        this.Sandwich = new Sandwich();
    }

    public SandwichBuilder buildJambonBeurre()
    {
        this.Reset();
        this.Sandwich.Add(new Ingredient("Pain", "unité"),1);
        this.Sandwich.Add(new Ingredient("Jambon", "tranche"),1);
        this.Sandwich.Add(new Ingredient("Beurre", "gramme"),1);
        return this;
    }

    
    
    public SandwichBuilder buildPouletCrudite()
    {
        this.Reset();
        this.Sandwich.Add(new Ingredient("Pain", "unité"),1);
        this.Sandwich.Add(new Ingredient("Poulet", "tranche"),1);
        this.Sandwich.Add(new Ingredient("Crudite", "gramme"),1);
        return this;
    }
    
    
    public SandwichBuilder buildDieppois()
    {
        this.Reset();
        this.Sandwich.Add(new Ingredient("Pain", "unité"),1);
        this.Sandwich.Add(new Ingredient("Dieppois", "tranche"),1);
        return this;
    }

    public Sandwich BuildSandwich()
    {
        return this.Sandwich;
    }
}