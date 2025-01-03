namespace OnlineLearningApp.Api.Services.Teachers.Dtos;

public class TeacherRequest
{
    
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Name { get; init; }
    public string Email { get; init; }
    public string PhoneNumber { get; init; }
    public string Address { get; init; }
    public DateTime DateOfBirth { get; init; }
}