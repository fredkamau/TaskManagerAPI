using Microsoft.EntityFrameworkCore;
using TaskManager.Data.Configuration;
using TaskManager.Data.Models;
using TaskManager.Services.Definitions;

namespace TaskManager.Services
{

    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly TaskManagerDBContext _context;

        public DepartmentRepository(TaskManagerDBContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> GetDepartments(int take)
        {
            return await _context.Departments.Take(take).ToListAsync();
        }
    }
}
