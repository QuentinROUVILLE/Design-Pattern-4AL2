using ProjectDesignPattern4AL2.Classes;

namespace ProjectDesignPattern4AL2.Storage.Command;

public class InMemoryCommand : ICommands
{
    private static readonly List<Classes.Command> _commandes;

    public void Add(Classes.Command Command)
    {
        _commandes.Add(Command);
    }

    public void Add(Dictionary<SandwichOrdered, int> sandwichesOrdered)
    {
        _commandes.Add(new Classes.Command(sandwichesOrdered));
    }

    public Classes.Command? Get(DateTime dateOfCreation)
    {
        return _commandes.FirstOrDefault(s => s.DateOfCreation == dateOfCreation);
    }
}