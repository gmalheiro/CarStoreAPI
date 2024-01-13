using CarStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarStoreAPI.Controllers;

[Route("api/[controller]/v1")]
[ApiController]
public class CarController : ControllerBase
{
    [HttpGet("FindAll")]
    [ProducesResponseType(typeof(List<Car>), 200)]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(401)]
    public ActionResult FindAll()
    {
        return Ok();
    }

    [HttpGet("FindById/{id}")]
    [ProducesResponseType(typeof(Car), 200)]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(401)]
    public ActionResult FindById()
    {
        return Ok();
    }

    [HttpPost]
    [ProducesResponseType(typeof(Car), 200)]
    [ProducesResponseType(400)]
    [ProducesResponseType(401)]
    public ActionResult Create()
    {
        return Ok();
    }
    
    [HttpPut]
    [ProducesResponseType(typeof(Car), 200)]
    [ProducesResponseType(400)]
    [ProducesResponseType(401)]
    public IActionResult Put([FromBody] Car car)
    {
        return Ok(car);
    }
    
    [HttpDelete("Delete/{id}")]
    [ProducesResponseType(typeof(Car), 200)]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(401)]
    public IActionResult Delete(int id)
    {
        return NoContent();
    }
}
