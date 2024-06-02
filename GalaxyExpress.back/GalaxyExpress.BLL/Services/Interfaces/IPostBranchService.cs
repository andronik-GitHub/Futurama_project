using GalaxyExpress.BLL.DTOs.PostBranchDTOs;
using GalaxyExpress.BLL.Extensions;

namespace GalaxyExpress.BLL.Services.Interfaces;

public interface IPostBranchService
{
    Task<List<PostBranchInfoDto>> GetAllAsync(string? searchText);
    Task<ServerResponse> DeleteAsync(Guid id);
    Task<ServerResponse> CheckExistenceByParametersAsync(int branchNumber, string globalAddress, string localAddress);
    Task<ServerResponse> AddAsync(AddPostBranchDto addPostBranchDTO);
}