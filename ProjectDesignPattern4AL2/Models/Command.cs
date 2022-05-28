namespace ProjectDesignPattern4AL2.Models;

public class Command
{
    public Command(Dictionary<SandwichOrdered, List<string>> sandwichesOrdered)
    {
        DateOfCreation = DateTime.Now;
        SandwichesOrdered = sandwichesOrdered;
    }

    public DateTime DateOfCreation { get; set; }
    public Dictionary<SandwichOrdered, List<string>> SandwichesOrdered { get; set; }
}