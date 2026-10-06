using Microsoft.AspNetCore.Mvc;
using SecureTaskApi.Models;
using SecureTaskApi.DTOs;
using System.Security.Cryptography;

namespace SecureTaskApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{

    //Lista memória para simular banco de dados
    private static List<TaskItem> _tasks = new();
    private static int _nextId = 1;

    [HttpGet]
    public IActionResult Get()
    {
        var response = _tasks.Select(task => new TaskResponse
        {
            Id = task.Id,
            Title = task.Title,
            Description = task.Description,
            IsCompleted = task.IsCompleted,
            CreatedAt = task.CreatedAt
        }).ToList();

        return Ok(response);
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateTaskRequest request)
    {
        var task = new TaskItem
        {
            Id = _nextId,
            Title = request.Title,
            Description = request.Description,
            IsCompleted = false,
            CreatedAt = DateTime.UtcNow,
            UserId = 1
        };

        _tasks.Add(task);
        
        _nextId++;

        var response = new TaskResponse
        {
            Id = task.Id,
            Title = task.Title,
            Description = task.Description,
            IsCompleted = task.IsCompleted,
            CreatedAt = task.CreatedAt
        };

        return CreatedAtAction(
           nameof(Get),
            new { id = task.Id},
            response
            );
    }
    
}