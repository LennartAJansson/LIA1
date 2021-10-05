// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Start1.Controllers
{
    using Exempel.Abstract;

    using Microsoft.AspNetCore.Mvc;

    using Start1.Model;

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMyService myService;

        public ValuesController(IMyService myService)
        {
            this.myService = myService;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(myService.GetAllPeople());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(myService.GetById(id));
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] Person value)
        {
            return Ok(myService.AddPerson(value));
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PersonOutput value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
