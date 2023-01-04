using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Core.Queries;
using TaskManager.Data.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ProjectController> _logger;

        public ProjectController(IMediator mediator, ILogger<ProjectController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        // GET: api/<ProjectsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetProjectQuery
            {
                Take = 10
            };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        // GET api/<ProjectsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProjectsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProjectsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProjectsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
