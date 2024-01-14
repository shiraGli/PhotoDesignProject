using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Servise;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServise _accountServise;
        public AccountController(IAccountServise accountServise)

        {
            _accountServise = accountServise;
        }
        // GET: api/<AccountController>
        [HttpGet]
        public ActionResult<Account>Get()
        {
            return Ok(_accountServise.GetAccount());
        }

        // GET api/<AccountController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AccountController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
