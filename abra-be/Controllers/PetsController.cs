using abra_be.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace abra_be.Controllers
{
    [Route("api/pet")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        // GET: api/<PetsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<PetsController>
        [HttpPost]
        public void Post([FromBody] Pet value)
        {
        }

    }
}
