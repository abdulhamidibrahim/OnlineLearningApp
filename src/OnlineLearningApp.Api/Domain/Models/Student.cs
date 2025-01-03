namespace OnlineLearningApp.Api.Domain.Models;

public class Student
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Email { get; init; }
    public string PhoneNumber { get; init; }
    public string Address { get; init; }
    public DateOnly DateOfBirth { get; init; }
    public string Grade { get; init; }
}