using GalaxyExpress.DAL.Entities;

namespace GalaxyExpress.DAL.Repositories.Interfaces;

public interface IPostBranchRepository : IGenericRepository<PostBranch, Guid>
{
    Task<PostBranch?> CheckExistenceByParametersAsync(int branchNumber, string globalAddress, string localAddress);
}