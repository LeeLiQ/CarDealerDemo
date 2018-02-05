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

        public void Add(Vehicle vehicle)
        {
            context.Vehicles.Add(vehicle);
        }

        public async Task<Vehicle> GetVehicle(int id, bool includeRelated = true)
        {
            if (!includeRelated)
                return await context.Vehicles.FindAsync(id);
            return
                await context.Vehicles
                        .Include(v => v.Features)
                            .ThenInclude(v => v.Feature)
                        .Include(v => v.Model)
                            .ThenInclude(m => m.Make)
                        .SingleOrDefaultAsync(v => v.Id == id);
        }

        public void Remove(Vehicle vehicle)
        {
            context.Vehicles.Remove(vehicle);
        }
    }
}