using API_Interactive_Lab_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers;


[ApiController]
[Route("[controller]")]
public class CoffeeController : ControllerBase
{
    
    [HttpGet("lover")]
    public string GetLoveTheCoffee()
    {
        return "I like coffee!";
    }

    [HttpGet("{name}")]

    public Coffee GetAvailableCoffees(string? name)
    {
        //I can use a fixed number for the ID (just for passing the tests)
        return new Coffee { Name = name ?? "latte" , Id = name!= null ? Random.Shared.Next(1,10) : -1};
    }
}
    
