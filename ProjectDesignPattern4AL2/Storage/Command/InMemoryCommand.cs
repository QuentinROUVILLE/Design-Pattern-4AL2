using ProjectDesignPattern4AL2.Models;

namespace ProjectDesignPattern4AL2.Storage.Command;

public class InMemoryCommand : ICommands
{
    private static readonly List<Models.Command> _commandes = new();

    public void Add(Models.Command command)
    {
        _commandes.Add(command);
    }

    public Models.Command? Get(DateTime dateOfCreation)
    {
        return _commandes.FirstOrDefault(s => s.DateOfCreation == dateOfCreation);
    }

    public void Add(Dictionary<SandwichOrdered, List<string>> sandwichesOrdered)
    {
        _commandes.Add(new Models.Command(sandwichesOrdered));
    }
}