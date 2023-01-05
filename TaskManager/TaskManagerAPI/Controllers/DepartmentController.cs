using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Core.Queries;
using TaskManager.Data.Models;

// For more information on enabling Web API for empty Departments, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<DepartmentController> _logger;

        public DepartmentController(IMediator mediator, ILogger<DepartmentController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        // GET: api/<DepartmentsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetDepartmentQuery
            {
                Take = 10
            };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        // GET api/<DepartmentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DepartmentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DepartmentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DepartmentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
