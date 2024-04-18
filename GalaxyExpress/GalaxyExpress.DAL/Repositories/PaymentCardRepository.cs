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
    public class PaymentCardRepository : GenericRepository<PaymentCard>, IPaymentCardRepository
    {
        public PaymentCardRepository(GalaxyExpressContext_SQLServer dbContext) : base(dbContext)
        {
        }


        public override async Task<IEnumerable<PaymentCard>> GetAllAsync()
        {
            return await entities
                .AsNoTracking()
                .Include(pc => pc.User)
                .ToListAsync();
        }

        public override async Task<PaymentCard?> GetByIdAsync(Guid id)
        {
            return await entities
                .AsNoTracking()
                .Include(pc => pc.User)
                .FirstOrDefaultAsync(pc => pc.CardId == id);
        }
    }
}
