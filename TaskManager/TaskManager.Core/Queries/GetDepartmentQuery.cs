using MediatR;
using TaskManager.Data.Models;
using TaskManager.Services.Definitions;

namespace TaskManager.Core.Queries
{
    public class GetDepartmentQuery : IRequest<List<Department>>
    {
        public int Take { get; set; }  
    }

    public class GetDepartmentQueryHandler : IRequestHandler<GetDepartmentQuery, List<Department>>
    {
        private readonly IDepartmentRepository _DepartmentRepository;

        public GetDepartmentQueryHandler(IDepartmentRepository DepartmentRepository)
        {
            _DepartmentRepository = DepartmentRepository;
        }

        public async Task<List<Department>> Handle(GetDepartmentQuery request, CancellationToken cancellationToken)
        {
            return await _DepartmentRepository.GetDepartments(request.Take);
        }
    }
}
