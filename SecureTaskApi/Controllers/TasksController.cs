using Microsoft.AspNetCore.Mvc;

namespace SecureTaskApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("API funcionando!");
    }
    
}