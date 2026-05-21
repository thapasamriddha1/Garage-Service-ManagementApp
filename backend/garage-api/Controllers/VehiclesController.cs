using Microsoft.AspNetCore.Mvc;

namespace garage_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehiclesController: ControllerBase
{
	[HttpGet]
	public IActionResult Get()
	{
		var vehicles = new[]
		{
			new {Id = 1, Brand = "Toyota", Model = "Corolla"},
			new {Id = 2, Brand = "Honda", Model = "Civic"}
		};
		return Ok(vehicles);	
	}
}
