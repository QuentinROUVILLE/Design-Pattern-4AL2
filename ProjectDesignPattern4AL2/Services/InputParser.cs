using ProjectDesignPattern4AL2.Models;
using ProjectDesignPattern4AL2.Storage.Command;
using ProjectDesignPattern4AL2.Storage.Sandwich;

namespace ProjectDesignPattern4AL2.Services;

public class InputParser
{
    private static readonly InMemorySandwich InMemorySandwich = new InMemorySandwich();
    private static readonly InMemoryCommand InMemoryCommand = new InMemoryCommand();
    
    public static Dictionary<SandwichOrdered, List<String>> ParseStringToSandwiches(string userInput)
    {
        string[] inputArray = userInput.Split(", ");
        Dictionary<SandwichOrdered, List<String>> sandwiches = new Dictionary<SandwichOrdered, List<String>>();
        
        foreach (var input in inputArray)
        {
            String buyer;
            String sandwich;
            try
            {
                buyer = input.Split(" ")[0];
                sandwich = input.Split(" ")[1];
            }
            catch (Exception e)
            {
                throw new ArgumentException("Votre commande n'a pas le bon format, veuillez recommencer");
            }

            SandwichOrdered sandwichToAdd = new SandwichOrdered(
                InMemorySandwich.GetSandwich(sandwich) ?? 
                throw new ArgumentException("Le sandwich " + sandwich + " n'existe pas"));

            if(sandwiches.ContainsKey(sandwichToAdd))
            {
                sandwiches[sandwichToAdd].Add(buyer);
            }
            else
            {
                sandwiches.Add(sandwichToAdd, new List<String>{buyer});
            }
        }
        
        InMemorySandwich.BuySandwiches(sandwiches);
        InMemoryCommand.Add(sandwiches);
        
        return sandwiches;
    }
    
    private static bool ContainsKey(Dictionary<SandwichOrdered, List<String>> sandwiches, SandwichOrdered sandwich)
    {
        foreach (var sandwichKey in sandwiches.Keys)
        {
            if(sandwichKey.Name == sandwich.Name)
            {
                return true;
            }
        }

        return false;
    }
}