using ProjectDesignPattern4AL2.Models;

namespace ProjectDesignPattern4AL2.Storage.Command;

public class InMemoryCommand : ICommands
{
    private static readonly List<Models.Command> _commandes = new List<Models.Command>();

    public void Add(Models.Command command)
    {
        _commandes.Add(command);
    }

    public void Add(Dictionary<SandwichOrdered, List<String>> sandwichesOrdered)
    {
        _commandes.Add(new Models.Command(sandwichesOrdered));
    }

    public Models.Command? Get(DateTime dateOfCreation)
    {
        return _commandes.FirstOrDefault(s => s.DateOfCreation == dateOfCreation);
    }
}