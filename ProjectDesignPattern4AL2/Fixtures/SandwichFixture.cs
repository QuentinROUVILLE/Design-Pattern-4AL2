using ProjectDesignPattern4AL2.Models;
using ProjectDesignPattern4AL2.Storage.Sandwich;

namespace ProjectDesignPattern4AL2.Fixtures;

public class SandwichFixture
{
    public static void Populate(ISandwiches sandwiches)
    {
        var pain = new Ingredient("Pain", "unité");
        var jambon = new Ingredient("Jambon", "tranche");
        var beurre = new Ingredient("Beurre", "gramme");
        var oeuf = new Ingredient("Oeuf", "unité");
        var tomate = new Ingredient("Tomate", "unité");
        var mayo = new Ingredient("Mayonnaise", "gramme");
        var salade = new Ingredient("Salade", "gramme");
        var poulet = new Ingredient("Poulet", "tranche");
        var thon = new Ingredient("Thon", "gramme");

        var ingredients = new Dictionary<Ingredient, double>
        {
            [pain] = 1,
            [jambon] = 1,
            [beurre] = 10
        };
        sandwiches.Add(new Sandwich("Jambon-beurre", ingredients, 3.50), 200);

        ingredients = new Dictionary<Ingredient, double>
        {
            [pain] = 1,
            [oeuf] = 1,
            [tomate] = 0.5,
            [poulet] = 1,
            [mayo] = 10,
            [salade] = 10
        };
        sandwiches.Add(new Sandwich("Poulet-Crudités", ingredients, 5), 200);

        ingredients = new Dictionary<Ingredient, double>
        {
            [pain] = 1,
            [thon] = 50,
            [tomate] = 0.5,
            [mayo] = 10,
            [salade] = 10
        };
        sandwiches.Add(new Sandwich("Dieppois", ingredients, 4.50), 200);
    }
}