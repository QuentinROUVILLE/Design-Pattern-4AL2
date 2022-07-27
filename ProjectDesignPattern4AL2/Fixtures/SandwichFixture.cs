using ProjectDesignPattern4AL2.Builder;
using ProjectDesignPattern4AL2.Models;
using ProjectDesignPattern4AL2.Storage.Sandwich;

namespace ProjectDesignPattern4AL2.Fixtures;

public class SandwichFixture
{
    public static void Populate(ISandwiches sandwiches)
    {
        sandwiches.Add(new SandwichBuilder().BuildJambonBeurre().BuildSandwich(), 2);
        sandwiches.Add(new SandwichBuilder().BuildPouletCrudites().BuildSandwich(), 3);
        sandwiches.Add(new SandwichBuilder().BuildDieppois().BuildSandwich(), 4);
    }
}