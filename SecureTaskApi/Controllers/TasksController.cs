using Microsoft.AspNetCore.Mvc;
using SecureTaskApi.Models;

namespace SecureTaskApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        var task = new TaskItem
        {
            Id = 1,
            Title = "Estudar .NET",
            Description = "Contruir uma API segura",
            IsCompleted = false,
            CreatedAt = DateTime.UtcNow,
            UserId = 1
        };

        return Ok(task);
    }
    
}