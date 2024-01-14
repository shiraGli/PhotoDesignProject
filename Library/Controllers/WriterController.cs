using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Servise;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WriterController : ControllerBase
    {
        private readonly IWriterServise _writerServise;
        public WriterController(IWriterServise writerServise)
        {
            _writerServise = writerServise;
        }
        // GET: api/<WriterController>
        [HttpGet]
        public ActionResult<Writer> Get()
        {
            return Ok(_writerServise.GetWriter());  
        }

        // GET api/<WriterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WriterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WriterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WriterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
