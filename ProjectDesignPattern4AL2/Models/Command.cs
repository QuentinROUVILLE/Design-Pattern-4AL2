namespace ProjectDesignPattern4AL2.Classes;

public class Command
{
    public int Id { get; set; }
    public SandwichOrdered[] SandwichesOrdered{ get; set; }

    public Command(int id, SandwichOrdered[] sandwichesOrdered)
    {
        Id = id;
        SandwichesOrdered = sandwichesOrdered;
    }
}