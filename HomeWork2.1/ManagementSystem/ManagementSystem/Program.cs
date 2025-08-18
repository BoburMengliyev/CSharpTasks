using ManagementSystem.Data;
using ManagementSystem.Services.ProjectServices;
using ManagementSystem.Services.TaskAssignmentServices;
using ManagementSystem.Services.TaskServices;
using ManagementSystem.Services.UserServices;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

namespace ManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<ManagementSystemDbContext>(options =>
                options.UseNpgsql(connectionString));

            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IProjectService, ProjectService>();
            builder.Services.AddScoped<ITaskService, TaskService>();
            builder.Services.AddScoped<ITaskAssignmentService, TaskAssignmentService>();

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
