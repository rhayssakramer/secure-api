using Microsoft.AspNetCore.Mvc;
using SecureTaskApi.Models;
using SecureTaskApi.DTOs;

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

        var response = new TaskResponse
        {
            Id = task.Id,
            Title = task.Title,
            Description = task.Description,
            IsCompleted = task.IsCompleted,
            CreateAdt = task.CreatedAt
        };

        return Ok(task);
    }
    
}