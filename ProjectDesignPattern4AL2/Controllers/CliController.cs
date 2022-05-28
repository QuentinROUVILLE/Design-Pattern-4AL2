using ProjectDesignPattern4AL2.Classes;
using ProjectDesignPattern4AL2.Services;

namespace ProjectDesignPattern4AL2.Controllers;

public class CliController
{
    public static void StartCli()
    {
        Console.WriteLine("Bienvenue dans la boulangerie du futur");
        do {
            try
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Veuillez saisir votre commande :");
                Dictionary<Sandwich, int> sandwiches = InputParser.ParseStringToSandwiches(Console.ReadLine());
                
                PrintBill(sandwiches);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } while (0 != 1);
    }
    
    private static void PrintBill(Dictionary<Sandwich, int> sandwiches)
    {
        double totalPrice = 0;
        foreach (var sandwich in sandwiches)
        {
            Console.WriteLine(sandwich.Key + " : " + sandwich.Value + " x " + sandwich.Key.Price + "€");
            totalPrice += sandwich.Key.Price * sandwich.Value;
        }
        Console.WriteLine("Prix total : " + totalPrice + "€");
    }
}