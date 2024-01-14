using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Servise;
using Solid.Servise;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityServise;
        public CityController(ICityService cityServise)
        {
            _cityServise = cityServise;
        }
        // GET: api/<CityController>
        [HttpGet]
        public ActionResult<City> Get()
        {
            return Ok(_cityServise.GetCity());
                }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
