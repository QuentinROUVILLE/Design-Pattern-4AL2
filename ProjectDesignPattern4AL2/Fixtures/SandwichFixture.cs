using ProjectDesignPattern4AL2.Models;
using ProjectDesignPattern4AL2.Storage.Sandwich;

namespace ProjectDesignPattern4AL2.Fixtures;

public class SandwichFixture
{
    public static void Populate(ISandwiches sandwiches)
    {
        Ingredient pain = new Ingredient("Pain", "unité");
        Ingredient jambon = new Ingredient("Jambon", "tranche");
        Ingredient beurre = new Ingredient("Beurre", "gramme");
        Ingredient oeuf = new Ingredient("Oeuf", "unité");
        Ingredient tomate = new Ingredient("Tomate", "unité");
        Ingredient mayo = new Ingredient("Mayonnaise", "gramme");
        Ingredient salade = new Ingredient("Salade", "gramme");
        Ingredient poulet = new Ingredient("Tranche de poulet", "tranche");
        Ingredient thon = new Ingredient("Thon", "gramme");

        var ingredients = new Dictionary<Ingredient, double>
        {
            [pain] = 1,
            [jambon] = 1,
            [beurre] = 10
        };
        sandwiches.Add(new Sandwich("Jambon beurre", ingredients, 3.50), 2);

        ingredients = new Dictionary<Ingredient, double>
        {
            [pain] = 1,
            [oeuf] = 1,
            [tomate] = 0.5,
            [poulet] = 1,
            [mayo] = 10,
            [salade] = 10
        };
        sandwiches.Add(new Sandwich("Poulet Crudités", ingredients, 5), 2);

        ingredients = new Dictionary<Ingredient, double>
        {
            [pain] = 1,
            [thon] = 50,
            [tomate] = 0.5,
            [mayo] = 10,
            [salade] = 10
        };
        sandwiches.Add(new Sandwich("Dieppois", ingredients, 4.50), 2);
    }
}