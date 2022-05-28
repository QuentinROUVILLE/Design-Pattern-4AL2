using ProjectDesignPattern4AL2.Models;
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
                Dictionary<SandwichOrdered, int> sandwiches = InputParser.ParseStringToSandwiches(Console.ReadLine());
                
                PrintBill(sandwiches);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } while (0 != 1);
    }
    
    private static void PrintBill(Dictionary<SandwichOrdered, int> sandwiches)
    {
        double totalPrice = 0;
        foreach (var sandwich in sandwiches)
        {
            Console.WriteLine(sandwich.Key.Name + " : " + sandwich.Value + " x " + sandwich.Key.Price + "€");
            foreach (var ingredient in sandwich.Key.Ingredients)
            {
                if (ingredient.Key.Unit == "unité")
                {
                    Console.WriteLine("\t" + ingredient.Value + " " + ingredient.Key.Name);
                }
                else
                {
                    Console.WriteLine("\t" + ingredient.Value + " " + ingredient.Key.Unit + " de " + ingredient.Key.Name);
                }
            }
            totalPrice += sandwich.Key.Price * sandwich.Value;
        }
        Console.WriteLine("Prix total : " + totalPrice + "€");
    }
}