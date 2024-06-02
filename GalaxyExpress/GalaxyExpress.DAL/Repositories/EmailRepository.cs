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
    public class EmailRepository : GenericRepository<Email>, IEmailRepository
    {
        public EmailRepository(GalaxyExpressDbContext dbContext) : base(dbContext)
        {
        }


        public override async Task<IEnumerable<Email>> GetAllAsync()
        {
            return await entities
                .AsNoTracking()
                .Include(e => e.User)
                .ToListAsync();
        }

        public override async Task<Email?> GetByIdAsync(Guid id)
        {
            return await entities
                .AsNoTracking()
                .Include(e => e.User)
                .FirstOrDefaultAsync(e => e.EmailId == id);
        }
    }
}
