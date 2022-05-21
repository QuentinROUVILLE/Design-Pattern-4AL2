namespace ProjectDesignPattern4AL2.Storage.Command;

public interface ICommands
{
    void Add(Classes.Command command);
    
    Classes.Command? Get(int id);
}