using ProjectDesignPattern4AL2.Classes;
using ProjectDesignPattern4AL2.Storage.Sandwich;

namespace ProjectDesignPattern4AL2.Services;

public class InputParser
{
    private static InMemorySandwich _inMemorySandwich = new InMemorySandwich();
    
    public static List<Sandwich> ParseStringToSandwiches(string input)
    {
        string[] inputArray = input.Split(',');
        List<Sandwich> sandwiches = new List<Sandwich>();
        
        for (int i = 0; i < inputArray.Length; i++)
        {
            sandwiches.Add(_inMemorySandwich.Get(inputArray[i]) ?? throw new ArgumentException("Le sandwich " + inputArray[i] + " n'existe pas"));
        }
        return sandwiches;
    }
}