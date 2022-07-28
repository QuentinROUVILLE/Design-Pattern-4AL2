using ProjectDesignPattern4AL2.Models;
namespace ProjectDesignPattern4AL2.Services;

public class BillPrinter
{
    public static void PrintBill(Bill bill)
    {
        foreach (KeyValuePair<SandwichOrdered, List<string>> sandwich in bill.Sandwiches)
        {
            Console.WriteLine(string.Join(" + ", sandwich.Value) + " | " + sandwich.Key.Name + " : " +
                              sandwich.Value.Count + " x " + sandwich.Key.Price + "€");
            foreach (KeyValuePair<Ingredient, Double> ingredient in sandwich.Key.Ingredients)
                if (ingredient.Key.Unit == "unité")
                    Console.WriteLine("\t" + ingredient.Value + " " + ingredient.Key.Name);
                else
                    Console.WriteLine(
                        "\t" + ingredient.Value + " " + ingredient.Key.Unit + " de " + ingredient.Key.Name);
        }

        Console.WriteLine("Prix total : " + bill.calculateBill() + "€");
    }
}