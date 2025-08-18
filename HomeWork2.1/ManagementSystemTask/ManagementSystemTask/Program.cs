using ManagementSystemTask.Data;
using ManagementSystemTask.Repositories.Projects;
using ManagementSystemTask.Repositories.TaskAssignments;
using ManagementSystemTask.Repositories.Tasks;
using ManagementSystemTask.Repositories.Users;
using ManagementSystemTask.Services.Projects;
using ManagementSystemTask.Services.TaskAssignments;
using ManagementSystemTask.Services.Tasks;
using ManagementSystemTask.Services.Users;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

namespace ManagementSystemTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ApplicationDbContext>(options => 
                options.UseNpgsql(connectionString));

            builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<ITaskAssignmentRepository, TaskAssignmentRepository>();
            builder.Services.AddScoped<ITaskRepository, TaskRepository>();

            builder.Services.AddScoped<IProjectService, ProjectService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<ITaskAssignmentService, TaskAssignmentService>();
            builder.Services.AddScoped<ITaskService, TaskService>();

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();

            WebApplication app = builder.Build();

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
