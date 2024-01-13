using CarStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarStoreAPI.Controllers
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet("FindAll")]
        [ProducesResponseType(typeof(List<Person>), 200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public ActionResult FindAll()
        {
            return Ok();
        }

        [HttpGet("FindById/{id}")]
        [ProducesResponseType(typeof(Person), 200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public ActionResult FindById()
        {
            return Ok();
        }

        [HttpPost("Create")]
        [ProducesResponseType(typeof(Person), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public ActionResult Create()
        {
            return Ok();
        }

        [HttpPut("Update")]
        [ProducesResponseType(typeof(Person), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Put([FromBody] Person person)
        {
            return Ok(person);
        }

        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(typeof(Person), 200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
