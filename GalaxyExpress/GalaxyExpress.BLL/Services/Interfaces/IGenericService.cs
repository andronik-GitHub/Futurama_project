using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.Services.Interfaces
{
    public interface IGenericService<TKey, TGetDTO, TInsertDTO, TUpdateDTO>
    {
        Task<TKey> CreateAsync(TInsertDTO entity);
        Task<TGetDTO?> GetAsync(TKey key);
        Task<IEnumerable<TGetDTO>> GetAllAsync();
        Task UpdateAsync(TUpdateDTO entity);
        Task DeleteAsync(TKey key);
    }
}
