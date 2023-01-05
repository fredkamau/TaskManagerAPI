using Microsoft.EntityFrameworkCore;
using TaskManager.Data.Configuration;
using TaskManager.Data.Models;
using TaskManager.Services.Definitions;

namespace TaskManager.Services
{

    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly TaskManagerDBContext _context;

        public EmployeeRepository(TaskManagerDBContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetEmployees(int take)
        {
            return await _context.Employees.Take(take).ToListAsync();
        }
    }
}
