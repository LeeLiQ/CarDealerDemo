using System.Threading.Tasks;
using CarDealer.Models;

namespace CarDealer.Repositories
{
    public interface IVehicleRepository
    {
        Task<Vehicle> GetVehicle(int id);
    }
}