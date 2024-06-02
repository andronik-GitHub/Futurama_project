using GalaxyExpress.BLL.DTOs.ParcelMachineDTOs;
using GalaxyExpress.BLL.Extensions;

namespace GalaxyExpress.BLL.Services.Interfaces;

public interface IParcelMachineService
{
    Task<List<ParcelMachineInfoDto>> GetAllAsync(string? searchText);
    Task<ServerResponse> DeleteAsync(Guid id);
    Task<ServerResponse> CheckExistenceByParametersAsync(int parcelMachineNumber, string globalAddress, string localAddress);
    Task<ServerResponse> AddAsync(AddParcelMachineDto addParcelMachineDTO);
}