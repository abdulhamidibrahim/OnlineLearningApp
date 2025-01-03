using OnlineLearningApp.Api.Domain.Models;
using OnlineLearningApp.Api.Services.Teachers.Dtos;

namespace OnlineLearningApp.Api.Services.TeacherService;

public interface ITeacherService
{
    public Task<int> CreateTeacher(TeacherRequest teacher, CancellationToken token);
    public Task<Teacher?> GetTeacherById(Guid id, CancellationToken token);
}