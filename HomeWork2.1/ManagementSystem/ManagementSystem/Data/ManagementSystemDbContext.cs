using ManagementSystem.Models.Projects;
using ManagementSystem.Models.TaskAssignments;
using ManagementSystem.Models.Tasks;
using ManagementSystem.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Data
{
    public class ManagementSystemDbContext : DbContext
    {
        public ManagementSystemDbContext(DbContextOptions<ManagementSystemDbContext> options)
            : base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }
        public DbSet<TaskAssignment> TaskAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Projects");
                entity.Property(p => p.Name).IsRequired().HasMaxLength(200);
                entity.Property(p => p.Description).HasMaxLength(2000);

                entity.HasMany(p => p.TaskItems)
                      .WithOne(t => t.Project)
                      .HasForeignKey(t => t.ProjectId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
                entity.Property(u => u.Name).IsRequired().HasMaxLength(200);
                entity.Property(u => u.Email).IsRequired().HasMaxLength(320);

                entity.HasIndex(u => u.Email).IsUnique();

                entity.HasMany(u => u.TaskItems)
                      .WithOne(t => t.User)
                      .HasForeignKey(t => t.UserId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(u => u.TaskAssignments)
                      .WithOne(ta => ta.User)
                      .HasForeignKey(ta => ta.UserId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<TaskItem>(entity =>
            {
                entity.ToTable("TaskItems");
                entity.Property(t => t.Title).IsRequired().HasMaxLength(200);
                entity.Property(t => t.Description).HasMaxLength(2000);

                entity.HasIndex(t => t.ProjectId);
                entity.HasIndex(t => t.UserId);
                entity.HasIndex(t => t.DueDate);

                entity.HasMany(t => t.TaskAssignments)
                      .WithOne(ta => ta.TaskItem)
                      .HasForeignKey(ta => ta.TaskItemId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<TaskAssignment>(entity =>
            {
                entity.ToTable("TaskAssignments");

                entity.HasIndex(ta => new { ta.TaskItemId, ta.UserId })
                      .IsUnique();
            });
        }
    }
}
