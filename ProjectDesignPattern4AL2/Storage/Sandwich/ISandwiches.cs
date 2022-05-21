namespace ProjectDesignPattern4AL2.Storage.Sandwich;

public interface ISandwiches
{
    void Add(Classes.Sandwich command);
    
    Classes.Sandwich? Get(string name);
}