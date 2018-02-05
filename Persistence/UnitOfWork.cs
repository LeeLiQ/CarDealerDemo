using System.Threading.Tasks;

namespace CarDealer.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CarDealerDbContext context;
        public UnitOfWork(CarDealerDbContext context)
        {
            this.context = context;
        }
        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}