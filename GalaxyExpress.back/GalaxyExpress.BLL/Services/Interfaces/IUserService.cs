﻿using GalaxyExpress.BLL.DTOs.UserDTOs;
using GalaxyExpress.DAL.Entities.Identity;
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

        // Identity
        Task<Guid> RegisterAsync(RegisterModel model);
        Task<Guid> RegisterManagerAsync(RegisterModel model);
        Task<Guid> RegisterAdminAsync(RegisterModel model);
        Task<bool> AddRoleAsync(AddRoleModel model);

        Task<AuthenticationModel> GetTokenAsync(LoginModel model);
    }
}
