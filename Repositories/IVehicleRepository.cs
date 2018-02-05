using System.Threading.Tasks;
using CarDealer.Models;

namespace CarDealer.Repositories
{
    public interface IVehicleRepository
    {
        Task<Vehicle> GetVehicle(int id, bool includeRelated = true);
        void Add(Vehicle vehicle);
        void Remove(Vehicle vehicle);
    }
}