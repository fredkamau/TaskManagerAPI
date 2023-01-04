using MediatR;
using TaskManager.Data.Models;
using TaskManager.Services.Definitions;

namespace TaskManager.Core.Queries
{
    public class GetProjectQuery : IRequest<List<Project>>
    {
        public int Take { get; set; }  
    }

    public class GetProjectQueryHandler : IRequestHandler<GetProjectQuery, List<Project>>
    {
        private readonly IProjectRepository _projectRepository;

        public GetProjectQueryHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<List<Project>> Handle(GetProjectQuery request, CancellationToken cancellationToken)
        {
            return await _projectRepository.GetProjects(request.Take);
        }
    }
}
