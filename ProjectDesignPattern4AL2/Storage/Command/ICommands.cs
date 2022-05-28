namespace ProjectDesignPattern4AL2.Storage.Command;

public interface ICommands
{
    void Add(Models.Command command);

    Models.Command? Get(DateTime dateOfCreation);
}