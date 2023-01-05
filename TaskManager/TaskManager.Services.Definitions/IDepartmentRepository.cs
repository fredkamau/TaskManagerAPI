using TaskManager.Data.Models;

namespace TaskManager.Services.Definitions
{
    public interface IDepartmentRepository  
    {
        Task<List<Department>> GetDepartments(int take);
    }
}
