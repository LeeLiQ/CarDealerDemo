using System;
using System.Threading.Tasks;
using AutoMapper;
using CarDealer.Models;
using CarDealer.Persistence;
using CarDealer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Controllers
{
    [Route("/api/[controller]")]
    public class VehiclesController : Controller
    {
        private readonly IMapper mapper;
        private readonly CarDealerDbContext context;
        public VehiclesController(IMapper mapper, CarDealerDbContext context)
        {
            this.context = context;
            this.mapper = mapper;

        }

        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody]VehicleResource vehicleResource)
        {
            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            vehicle.LastUpdate = DateTime.UtcNow;
            context.Vehicles.Add(vehicle);
            await context.SaveChangesAsync();

            var result = mapper.Map<Vehicle, VehicleResource>(vehicle);

            return Ok(result);
        }
    }
}