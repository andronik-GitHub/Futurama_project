using GalaxyExpress.BLL.DTOs.PhoneNumberDTOs;
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
    public class PhoneNumberService : IPhoneNumberService
    {
        private IUnitOfWork _uow;

        public PhoneNumberService(IUnitOfWork uow)
        {
            _uow = uow;
        }


        public async Task<Guid> CreateAsync(InsertDTO_PhoneNumber entity)
        {
            PhoneNumber phoneNumber = MappingFunctions.MapSourceToDestination<InsertDTO_PhoneNumber, PhoneNumber>(entity); // Mapping with Mapster

            var id = await _uow.PhoneNumbers.CreateAsync(phoneNumber);
            await _uow.SaveChangesAsync();

            return id;
        }
        public async Task<IEnumerable<GetDTO_PhoneNumber>> GetAllAsync()
        {
            // Use Mapster to project one collection onto another
            return MappingFunctions.MapListSourceToDestination<PhoneNumber, GetDTO_PhoneNumber>
                (await _uow.PhoneNumbers.GetAllAsync());
        }
        public async Task<GetDTO_PhoneNumber?> GetAsync(Guid key)
        {
            PhoneNumber? phoneNumber = await _uow.PhoneNumbers.GetByIdAsync(key);

            GetDTO_PhoneNumber? phoneNumberDTO = MappingFunctions
                .MapSourceToDestination<PhoneNumber?, GetDTO_PhoneNumber?>(phoneNumber); // Mapping with Mapster

            return phoneNumberDTO;
        }
        public async Task UpdateAsync(UpdateDTO_PhoneNumber entity)
        {
            PhoneNumber phoneNumber = MappingFunctions.MapSourceToDestination<UpdateDTO_PhoneNumber, PhoneNumber>(entity); // Mapping with Mapster

            await _uow.PhoneNumbers.UpdateAsync(phoneNumber);
            await _uow.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid key)
        {
            await _uow.PhoneNumbers.DeleteAsync(key);
            await _uow.SaveChangesAsync();
        }
    }
}
