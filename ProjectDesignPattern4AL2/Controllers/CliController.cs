using ProjectDesignPattern4AL2.Classes;
using ProjectDesignPattern4AL2.Services;

namespace ProjectDesignPattern4AL2.Controllers;

public class CliController
{
    public static void StartCli()
    {
        Console.WriteLine("Bienvenue dans la boulagenrie du futur");
        do {
            try
            {
                Console.WriteLine("Veuillez saisir votre commande :");
                List<Sandwich> sandwiches = InputParser.ParseStringToSandwiches(Console.ReadLine());
                PrintSandwiches(sandwiches);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } while (0 != 1);
    }
    
    private static void PrintSandwiches(List<Sandwich> sandwiches)
    {
        foreach (var sandwich in sandwiches)
        {
            Console.WriteLine(sandwich.ToString());
        }
    }
}