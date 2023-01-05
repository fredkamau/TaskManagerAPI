using Microsoft.EntityFrameworkCore;
using TaskManager.Data.Models;

namespace TaskManager.Data.Configuration
{
    public class TaskManagerDBContext : DbContext
    {
        public TaskManagerDBContext(DbContextOptions<TaskManagerDBContext> options): 
            base(options)
        {

        }

        public DbSet<Project> Projects { get; set; } = null!;
        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Models.Task> Tasks { get; set; } = null!;
    }
}
