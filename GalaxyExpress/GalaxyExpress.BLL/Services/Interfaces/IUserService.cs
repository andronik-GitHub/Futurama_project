using GalaxyExpress.BLL.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.Services.Interfaces
{
    public interface IUserService : IGenericService<Guid, GetDTO_User, InsertDTO_User, UpdateDTO_User>
    {
        Task<int> GetCountOfUsersAsync();
        Task<int> GetCountOfUsersNotDeletedAsync(); 
    }
}
