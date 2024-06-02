using GalaxyExpress.BLL.DTOs.PaymentCardDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.Services.Interfaces
{
    public interface IPaymentCardService : IGenericService<Guid, GetDTO_PaymentCard, InsertDTO_PaymentCard, UpdateDTO_PaymentCard>
    {
    }
}
