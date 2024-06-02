using GalaxyExpress.DAL.Entities;

namespace GalaxyExpress.DAL.Repositories.Interfaces;

public interface IParcelMachineRepository : IGenericRepository<ParcelMachine, Guid>
{
    Task<ParcelMachine?> CheckExistenceByParametersAsync(int parcelMachineNumber, string globalAddress, string localAddress);
}