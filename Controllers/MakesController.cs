using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CarDealer.Models;
using CarDealer.Persistence;
using CarDealer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.Controllers
{
    public class MakesController : Controller
    {
        private readonly CarDealerDbContext context;
        private readonly IMapper mapper;
        public MakesController(CarDealerDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}