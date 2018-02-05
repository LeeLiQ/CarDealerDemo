using System.Threading.Tasks;

namespace CarDealer.Persistence
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}