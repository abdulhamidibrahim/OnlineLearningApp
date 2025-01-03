using Microsoft.AspNetCore.Mvc;
using OnlineLearningApp.Api.Domain.Models;
using OnlineLearningApp.Api.Services.Teachers.Dtos;
using OnlineLearningApp.Api.Services.TeacherService;

namespace OnlineLearningApp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class TeachersController(ITeacherService teacherService) : ControllerBase
{
    [HttpPost("create")]
    public async Task<IActionResult> CreateTeacher(TeacherRequest teacher)
    {
        var result = await teacherService.CreateTeacher(teacher, CancellationToken.None);
        if (result == 0)
        {
            return BadRequest(new{ Message = "Failed already exists"});
        }
        return Ok();
    }

    [HttpGet("{id}")]
    
    public async Task<IActionResult> GetTeacher(Guid id)
    {
        var teacher = await teacherService.GetTeacherById(id, CancellationToken.None);
        return Ok(new { teacher });
    }
}