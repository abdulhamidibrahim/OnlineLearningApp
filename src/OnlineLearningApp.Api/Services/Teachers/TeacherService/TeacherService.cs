using Dapper;
using OnlineLearningApp.Api.Domain.DbConnection;
using OnlineLearningApp.Api.Domain.Models;
using OnlineLearningApp.Api.Services.Teachers.Dtos;

namespace OnlineLearningApp.Api.Services.TeacherService;

public class TeacherService(IDbConnectionFactory dbConnection) : ITeacherService
{
    public async Task<int> CreateTeacher(TeacherRequest teacher,CancellationToken token)
    {
        using var connection = dbConnection.CreateConnection(token);

        var command = await connection
                      .ExecuteAsync(
                                                $"""
                                                     INSERT INTO Teachers (id, name, email, phoneNumber, address, dateOfBirth)
                                                 
                                                     VALUES (@id,@Name, @Email, @PhoneNumber, @Address, @DateOfBirth) 
                                                     """
                                                 , new{teacher.Id, teacher.Name, teacher.Email, teacher.PhoneNumber, teacher.Address, teacher.DateOfBirth});
        connection.Close();
        return command;
    }

    public async Task<Teacher?> GetTeacherById(Guid id, CancellationToken token)
    {
        using var connection = dbConnection.CreateConnection(token);

        var command = await connection.QueryFirstOrDefaultAsync($"""
                                                                  
                                                                 SELECT * FROM Teachers WHERE id = @id
                                                                 """, new { id });
        connection.Close();
        var teacher = new Teacher()
        {
            Id = command?.id,
            Name = command?.name,
            Email = command?.email,
            PhoneNumber = command?.phoneNumber, 
            Address = command?.address,
            DateOfBirth = command?.dateOfBirth,
        };
        return teacher;
    }
}