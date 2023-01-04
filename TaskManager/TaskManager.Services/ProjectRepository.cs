using Microsoft.EntityFrameworkCore;
using TaskManager.Data.Configuration;
using TaskManager.Data.Models;
using TaskManager.Services.Definitions;

namespace TaskManager.Services
{

    public class ProjectRepository : IProjectRepository
    {
        private readonly TaskManagerDBContext _context;

        public ProjectRepository(TaskManagerDBContext context)
        {
            _context = context;
        }

        public async Task<List<Project>> GetProjects(int take)
        {
            return await _context.Projects.Take(take).ToListAsync();
        }
    }
}
