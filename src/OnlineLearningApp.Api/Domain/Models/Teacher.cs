namespace OnlineLearningApp.Api.Domain.Models;

public class Teacher
{
    public Teacher()
    {
        Id = Guid.NewGuid();
    }
    
    public Guid Id { get; init; } 
    public string Name { get; init; }
    public string Email { get; init; }
    public string PhoneNumber { get; init; }
    public string Address { get; init; }
    public DateTime DateOfBirth { get; init; }
}