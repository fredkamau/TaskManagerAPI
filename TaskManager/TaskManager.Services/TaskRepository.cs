using Microsoft.EntityFrameworkCore;
using TaskManager.Data.Configuration;
using TaskManager.Data.Models;
using TaskManager.Services.Definitions;
using Task = TaskManager.Data.Models.Task;

namespace TaskManager.Services
{

    public class TaskRepository : ITaskRepository
    {
        private readonly TaskManagerDBContext _context;

        public TaskRepository(TaskManagerDBContext context)
        {
            _context = context;
        }

        public async Task<List<Task>> GetTasks(int take)
        {
            return await _context.Tasks.Take(take).ToListAsync();
        }
    }
}
