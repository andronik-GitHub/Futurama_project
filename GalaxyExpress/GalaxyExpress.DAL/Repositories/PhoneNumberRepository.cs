using GalaxyExpress.DAL.Data;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Repositories
{
    public class PhoneNumberRepository : GenericRepository<PhoneNumber>, IPhoneNumberRepository
    {
        public PhoneNumberRepository(GalaxyExpressContext_SQLServer dbContext) : base(dbContext)
        {
        }


        public override async Task<IEnumerable<PhoneNumber>> GetAllAsync()
        {
            return await entities
                .AsNoTracking()
                .Include(pn => pn.User)
                .ToListAsync();
        }

        public override async Task<PhoneNumber?> GetByIdAsync(Guid id)
        {
            return await entities
                .AsNoTracking()
                .Include(pn => pn.User)
                .FirstOrDefaultAsync(pn => pn.PhoneNumberId == id);
        }
    }
}
