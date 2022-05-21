using ProjectDesignPattern4AL2.Classes;

namespace ProjectDesignPattern4AL2.Storage;

public class InMemoryCommand
{
    private readonly List<Command> _commandes;

    public void Add(Command Command)
    {
        _commandes.Add(Command);
    }

    public Command? Get(int id)
    {
        return _commandes.FirstOrDefault(s => s.Id == id);
    }
}