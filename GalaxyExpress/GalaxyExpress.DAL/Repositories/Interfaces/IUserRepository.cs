using GalaxyExpress.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<User, Guid>
    {
        Task<int> GetCountOfUsersAsync();
        Task<int> GetCountOfUsersNotDeletedAsync();
        Task<User?> GetByEmailAsync(string email);
        Task<User?> GetByUsernameAsync(string username); 
        Task<User?> GetByLoginAsync(string login);
    }
}
