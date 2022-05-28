namespace ProjectDesignPattern4AL2.Models;

public class Command
{
    public DateTime DateOfCreation { get; set; }
    public Dictionary<SandwichOrdered, int> SandwichesOrdered{ get; set; }

    public Command(Dictionary<SandwichOrdered, int> sandwichesOrdered)
    {
        DateOfCreation = DateTime.Now;
        SandwichesOrdered = sandwichesOrdered;
    }
}