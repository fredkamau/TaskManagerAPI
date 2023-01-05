using MediatR;
using TaskManager.Data.Models;
using TaskManager.Services.Definitions;

namespace TaskManager.Core.Queries
{
    public class GetEmployeeQuery : IRequest<List<Employee>>
    {
        public int Take { get; set; }  
    }

    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, List<Employee>>
    {
        private readonly IEmployeeRepository _EmployeeRepository;

        public GetEmployeeQueryHandler(IEmployeeRepository EmployeeRepository)
        {
            _EmployeeRepository = EmployeeRepository;
        }

        public async Task<List<Employee>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await _EmployeeRepository.GetEmployees(request.Take);
        }
    }
}
