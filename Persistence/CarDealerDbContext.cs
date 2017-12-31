using CarDealer.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.Persistence

{
    public class CarDealerDbContext : DbContext
    {
        public CarDealerDbContext(DbContextOptions<CarDealerDbContext> options)
                :base(options)
        {
            
        }

        public DbSet<Make> Makes { get; set; }
    }
}