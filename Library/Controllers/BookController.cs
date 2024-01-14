using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Servise;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookServise _bookServise;
        public BookController(IBookServise bookServise)
        {
            _bookServise = bookServise;
        }
        // GET: api/<BookController>
        [HttpGet]
        public ActionResult<Book> Get()
        {
            return Ok(_bookServise.GetBook());
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
