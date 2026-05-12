using Microsoft.AspNetCore.Mvc;

namespace TrickingLibarary.Api.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Index() 
    {
        return Ok(new { message = "Hello World!" });
    }
}