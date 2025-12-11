namespace FacadeDP;

public class InventoryService : IinventoryService
{
    public string[] get()
    {
        return new string[] { "ASP", "Node", "Golang" , "Laravel" , "Angular" , "Next" };
    }
}
