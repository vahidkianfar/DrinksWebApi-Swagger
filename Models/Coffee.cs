namespace API_Interactive_Lab_1.Models;

public class Coffee
{
    public string Name { get; set; }
    public string Id { get; set; }

    public Coffee(string name, string id)
    {
        Name = name;
        Id = id;
    }
    
}