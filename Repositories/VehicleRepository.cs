using System.Threading.Tasks;
using CarDealer.Models;
using CarDealer.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly CarDealerDbContext context;
        public VehicleRepository(CarDealerDbContext context)
        {
            this.context = context;
        }

        public async Task<Vehicle> GetVehicle(int id)
        {
            return
                await context.Vehicles
                        .Include(v => v.Features)
                            .ThenInclude(v => v.Feature)
                        .Include(v => v.Model)
                            .ThenInclude(m => m.Make)
                        .SingleOrDefaultAsync(v => v.Id == id);
        }
    }
}