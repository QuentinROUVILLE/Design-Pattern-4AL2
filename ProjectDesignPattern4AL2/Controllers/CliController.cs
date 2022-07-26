using ProjectDesignPattern4AL2.Models;
using ProjectDesignPattern4AL2.Services;

namespace ProjectDesignPattern4AL2.Controllers;

public class CliController
{
    public static void StartCli()
    {
        Console.WriteLine("Bienvenue dans la boulangerie du futur");
        do
        {
            try
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Veuillez saisir votre commande :");
                var sandwiches = InputParser.ParseStringToSandwiches(Console.ReadLine());
                Bill bill = new Bill(sandwiches);
                BillPrinter.PrintBill(bill);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } while (0 != 1);
    }
}