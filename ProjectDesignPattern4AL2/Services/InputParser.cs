using ProjectDesignPattern4AL2.Models;
using ProjectDesignPattern4AL2.Storage.Command;
using ProjectDesignPattern4AL2.Storage.Sandwich;

namespace ProjectDesignPattern4AL2.Services;

public class InputParser
{
    private static readonly InMemorySandwich InMemorySandwich = new();
    private static readonly InMemoryCommand InMemoryCommand = new();

    public static Dictionary<SandwichOrdered, List<string>> ParseStringToSandwiches(string userInput)
    {
        String[] inputArray = userInput.Split(", ");
        var sandwiches = new Dictionary<SandwichOrdered, List<string>>();

        foreach (String input in inputArray)
        {
            string buyer;
            string sandwich;
            try
            {
                buyer = input.Split(" ")[0];
                sandwich = input.Split(" ")[1];
            }
            catch (Exception e)
            {
                throw new ArgumentException("Votre commande n'a pas le bon format, veuillez recommencer");
            }

            var sandwichToAdd = new SandwichOrdered(
                InMemorySandwich.GetSandwich(sandwich) ??
                throw new ArgumentException("Le sandwich " + sandwich + " n'existe pas"));

            if (sandwiches.ContainsKey(sandwichToAdd))
                sandwiches[sandwichToAdd].Add(buyer);
            else
                sandwiches.Add(sandwichToAdd, new List<string> {buyer});
        }

        InMemorySandwich.BuySandwiches(sandwiches);
        InMemoryCommand.Add(sandwiches);

        return sandwiches;
    }
}