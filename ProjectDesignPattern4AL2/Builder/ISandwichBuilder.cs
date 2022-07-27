namespace ProjectDesignPattern4AL2.Builder;

public interface ISandwichBuilder
{
    
    public void Reset();
    
    public SandwichBuilder BuildJambonBeurre();

    public SandwichBuilder BuildPouletCrudites();
    
    public SandwichBuilder BuildDieppois();

}