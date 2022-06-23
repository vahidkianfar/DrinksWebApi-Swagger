using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers;


[ApiController]
[Route("[controller]/lover")]
public class CoffeeController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "I like coffee!";
    }
}
    
