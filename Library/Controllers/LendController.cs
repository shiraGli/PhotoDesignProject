using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Servise;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LendController : ControllerBase
    {
        private readonly ILendServise _lendServise;
        public LendController(ILendServise lendServise)
        {
            _lendServise = lendServise;
        }
        // GET: api/<LendController>
        [HttpGet]
        public ActionResult<Lend> Get()
        {
            return Ok(_lendServise.GetLend());
                }

        // GET api/<LendController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LendController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LendController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LendController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
