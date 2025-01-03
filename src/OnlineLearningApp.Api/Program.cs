using OnlineLearningApp.Api.Domain.DbConnection;
using OnlineLearningApp.Api.Services.TeacherService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddControllers();

builder.Services.AddScoped<ITeacherService, TeacherService>();
builder.Services.AddSingleton<IDbConnectionFactory>(_=> new DbConnectionFactory(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
