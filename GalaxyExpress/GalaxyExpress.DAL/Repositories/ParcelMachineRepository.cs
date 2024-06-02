using GalaxyExpress.DAL.Data;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GalaxyExpress.DAL.Repositories;

public class ParcelMachineRepository : GenericRepository<ParcelMachine>, IParcelMachineRepository
{
    public ParcelMachineRepository(GalaxyExpressDbContext dbContext) : base(dbContext) { }

    public async Task<ParcelMachine?> CheckExistenceByParametersAsync(int parcelMachineNumber, string globalAddress, string localAddress)
       => await dbContext.ParcelMachines.AsNoTracking()
       .SingleOrDefaultAsync(x => x.ParcelMachineNumber.Equals(parcelMachineNumber) && x.GlobalAddress.Equals(globalAddress)
       && x.LocalAddress.Equals(localAddress));
}