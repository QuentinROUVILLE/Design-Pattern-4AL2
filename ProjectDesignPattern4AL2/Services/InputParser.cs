using ProjectDesignPattern4AL2.Classes;
using ProjectDesignPattern4AL2.Storage.Sandwich;

namespace ProjectDesignPattern4AL2.Services;

public class InputParser
{
    private static readonly InMemorySandwich InMemorySandwich = new InMemorySandwich();
    
    public static Dictionary<Sandwich, int> ParseStringToSandwiches(string input)
    {
        string[] inputArray = input.Split(", ");
        Dictionary<Sandwich, int> sandwiches = new Dictionary<Sandwich, int>();
        
        foreach (string sandwich in inputArray)
        {
            Sandwich sandwichToAdd = InMemorySandwich.GetSandwich(sandwich) ?? 
                                     throw new ArgumentException("Le sandwich " + sandwich + " n'existe pas");
            
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
        
        return sandwiches;
    }
}