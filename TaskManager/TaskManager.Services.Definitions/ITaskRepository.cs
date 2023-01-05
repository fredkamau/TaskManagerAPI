using Task = TaskManager.Data.Models.Task;

namespace TaskManager.Services.Definitions
{
    public interface ITaskRepository  
    {
        Task<List<Task>> GetTasks(int take);
    }
}
