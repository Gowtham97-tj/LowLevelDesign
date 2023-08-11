using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VehicleParking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingSpaceController : ControllerBase
    {
        // GET: api/<ParkingSpaceController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ParkingSpaceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ParkingSpaceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ParkingSpaceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ParkingSpaceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
