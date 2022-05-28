namespace ProjectDesignPattern4AL2.Models;

public class Command
{
    public DateTime DateOfCreation { get; set; }
    public Dictionary<SandwichOrdered, List<String>> SandwichesOrdered{ get; set; }

    public Command(Dictionary<SandwichOrdered, List<String>> sandwichesOrdered)
    {
        DateOfCreation = DateTime.Now;
        SandwichesOrdered = sandwichesOrdered;
    }
}