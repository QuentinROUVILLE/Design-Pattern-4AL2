using ProjectDesignPattern4AL2.Models;
using ProjectDesignPattern4AL2.Storage.Command;
using ProjectDesignPattern4AL2.Storage.Sandwich;

namespace ProjectDesignPattern4AL2.Services;

public class InputParser
{
    private static readonly InMemorySandwich InMemorySandwich = new InMemorySandwich();
    private static readonly InMemoryCommand InMemoryCommand = new InMemoryCommand();
    
    public static Dictionary<SandwichOrdered, int> ParseStringToSandwiches(string input)
    {
        string[] inputArray = input.Split(", ");
        Dictionary<SandwichOrdered, int> sandwiches = new Dictionary<SandwichOrdered, int>();
        
        foreach (string sandwich in inputArray)
        {
            SandwichOrdered sandwichToAdd = new SandwichOrdered(
                InMemorySandwich.GetSandwich(sandwich) ?? 
                throw new ArgumentException("Le sandwich " + sandwich + " n'existe pas"));

            if(sandwiches.ContainsKey(sandwichToAdd))
            {
                sandwiches[sandwichToAdd]++;
            }
            else
            {
                sandwiches.Add(sandwichToAdd, 1);
            }
        }
        
        InMemorySandwich.BuySandwiches(sandwiches);
        InMemoryCommand.Add(sandwiches);
        
        return sandwiches;
    }
}