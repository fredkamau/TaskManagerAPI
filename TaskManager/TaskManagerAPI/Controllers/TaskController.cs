using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Core.Queries;
using TaskManager.Data.Models;

// For more information on enabling Web API for empty Tasks, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<TaskController> _logger;

        public TaskController(IMediator mediator, ILogger<TaskController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        // GET: api/<TasksController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetTaskQuery
            {
                Take = 10
            };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        // GET api/<TasksController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TasksController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TasksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TasksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
