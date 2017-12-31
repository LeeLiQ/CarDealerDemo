using System.Collections.Generic;
using System.Threading.Tasks;
using CarDealer.Models;
using CarDealer.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.Controllers
{
    public class MakesController : Controller
    {
        private readonly CarDealerDbContext context;
        public MakesController(CarDealerDbContext context)
        {
            this.context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await context.Makes.Include(m => m.Models).ToListAsync();
        }
    }
}