using GalaxyExpress.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Repositories.Interfaces
{
    public interface IPaymentCardRepository : IGenericRepository<PaymentCard, Guid>
    {
    }
}
