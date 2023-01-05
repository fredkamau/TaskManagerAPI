using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Core.Queries;
using TaskManager.Data.Models;

// For more information on enabling Web API for empty Employees, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(IMediator mediator, ILogger<EmployeeController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        // GET: api/<EmployeesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetEmployeeQuery
            {
                Take = 10
            };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
