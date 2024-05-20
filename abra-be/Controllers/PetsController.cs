using abra_be.Models;
using abra_be.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace abra_be.Controllers
{
    [Route("api/pet")]
    [ApiController]
    public class PetsController : ControllerBase
    {

        private readonly MongoDBService _petsService;

        public PetsController(MongoDBService petsService)
        {
            _petsService = petsService;
        }

        // GET: api/<PetsController>
        [HttpGet]
        public async Task<List<Pet>> Get()
        {
            return await _petsService.GetAsync();
        }

        // POST api/<PetsController>
        [HttpPost]
        public void Post([FromBody] Pet value)
        {
            _petsService.CreateAsync(value);
        }

    }
}
