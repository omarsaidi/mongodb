using OpenSky.Models;
using Microsoft.AspNetCore.Mvc;
using OpenSky.Services;

namespace OpenSky.Controllers;

[ApiController]
[Route("[controller]")]
public class AircraftsController : ControllerBase
{
	private readonly AircraftService _aircraftService;

        public AircraftsController(AircraftService aircraftService)
        {
            _aircraftService = aircraftService;
        }

        [HttpGet]
        public IActionResult Get(int page) { 
       		List<Aircraft> aircrafts =  _aircraftService.Get(page);
		return View(aircrafts);	
	}

        [HttpGet("{id:length(24)}", Name = "GetBook")]
        public IActionResult Get(string id)
        {
            Aircraft aircraft = _aircraftService.Get(id);

            if (aircraft == null)
            {
                return NotFound();
            }

            return View(aircraft);
        }

}
