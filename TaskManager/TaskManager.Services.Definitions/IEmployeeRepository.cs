using TaskManager.Data.Models;

namespace TaskManager.Services.Definitions
{
    public interface IEmployeeRepository  
    {
        Task<List<Employee>> GetEmployees(int take);
    }
}
