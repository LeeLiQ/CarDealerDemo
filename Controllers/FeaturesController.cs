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
    public class FeaturesController : Controller
    {
        private readonly CarDealerDbContext context;
        private readonly IMapper mapper;
        public FeaturesController(CarDealerDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<KeyValuePairResource>> GetFeatures()
        {
            var features = await context.Features.ToListAsync();
            return mapper.Map<List<Feature>, List<KeyValuePairResource>>(features);
        }
    }
}