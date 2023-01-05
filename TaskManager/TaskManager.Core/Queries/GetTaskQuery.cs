using MediatR;
using TaskManager.Data.Models;
using TaskManager.Services.Definitions;
using Task = TaskManager.Data.Models.Task;

namespace TaskManager.Core.Queries
{
    public class GetTaskQuery : IRequest<List<Task>>
    {
        public int Take { get; set; }  
    }

    public class GetTaskQueryHandler : IRequestHandler<GetTaskQuery, List<Task>>
    {
        private readonly ITaskRepository _TaskRepository;

        public GetTaskQueryHandler(ITaskRepository TaskRepository)
        {
            _TaskRepository = TaskRepository;
        }

        public async Task<List<Task>> Handle(GetTaskQuery request, CancellationToken cancellationToken)
        {
            return await _TaskRepository.GetTasks(request.Take);
        }
    }
}
