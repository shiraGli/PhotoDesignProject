using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Servise;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Book_on_loanController : ControllerBase
    {
        private readonly IBook_on_loanServise _book_On_LoanServise ;
        public Book_on_loanController(IBook_on_loanServise book_On_LoanServise)
        {
            _book_On_LoanServise = book_On_LoanServise;
        }
        // GET: api/<Book_on_loanController>
        [HttpGet]
        public ActionResult<Books_on_loan> Get()
        {
            return Ok(_book_On_LoanServise.GetBooks_on_loan());
        }

        // GET api/<Book_on_loanController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Book_on_loanController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Book_on_loanController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Book_on_loanController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
