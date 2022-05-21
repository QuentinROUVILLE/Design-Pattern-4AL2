namespace ProjectDesignPattern4AL2.Storage.Command;

public class InMemoryCommand : ICommands
{
    private static readonly List<Classes.Command> _commandes;

    public void Add(Classes.Command Command)
    {
        _commandes.Add(Command);
    }

    public Classes.Command? Get(int id)
    {
        return _commandes.FirstOrDefault(s => s.Id == id);
    }
}