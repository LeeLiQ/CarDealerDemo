using AutoMapper;
using CarDealer.Models;
using CarDealer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Controllers
{
    [Route("/api/[controller]")]
    public class VehiclesController : Controller
    {
        private readonly IMapper mapper;
        public VehiclesController(IMapper mapper)
        {
            this.mapper = mapper;

        }

        [HttpPost]
        public IActionResult CreateVehicle([FromBody]VehicleResource vehicleResource)
        {
            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            return Ok(vehicle);
        }
    }
}