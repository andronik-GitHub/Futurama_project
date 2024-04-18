using GalaxyExpress.BLL.DTOs.PaymentCardDTOs;
using GalaxyExpress.BLL.Mapping;
using GalaxyExpress.BLL.Services.Interfaces;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.Services
{
    public class PaymentCardService : IPaymentCardService
    {
        private IUnitOfWork _uow;

        public PaymentCardService(IUnitOfWork uow)
        {
            _uow = uow;
        }


        public async Task<Guid> CreateAsync(InsertDTO_PaymentCard entity)
        {
            PaymentCard paymentCard = MappingFunctions.MapSourceToDestination<InsertDTO_PaymentCard, PaymentCard>(entity); // Mapping with Mapster

            var id = await _uow.PaymentCards.CreateAsync(paymentCard);
            await _uow.SaveChangesAsync();

            return id;
        }
        public async Task<IEnumerable<GetDTO_PaymentCard>> GetAllAsync()
        {
            // Use Mapster to project one collection onto another
            return MappingFunctions.MapListSourceToDestination<PaymentCard, GetDTO_PaymentCard>
                (await _uow.PaymentCards.GetAllAsync());
        }
        public async Task<GetDTO_PaymentCard?> GetAsync(Guid key)
        {
            PaymentCard? paymentCard = await _uow.PaymentCards.GetByIdAsync(key);

            GetDTO_PaymentCard? paymentCardDTO = MappingFunctions
                .MapSourceToDestination<PaymentCard?, GetDTO_PaymentCard?>(paymentCard); // Mapping with Mapster

            return paymentCardDTO;
        }
        public async Task UpdateAsync(UpdateDTO_PaymentCard entity)
        {
            PaymentCard paymentCard = MappingFunctions.MapSourceToDestination<UpdateDTO_PaymentCard, PaymentCard>(entity); // Mapping with Mapster

            await _uow.PaymentCards.UpdateAsync(paymentCard);
            await _uow.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid key)
        {
            await _uow.PaymentCards.DeleteAsync(key);
            await _uow.SaveChangesAsync();
        }
    }
}
