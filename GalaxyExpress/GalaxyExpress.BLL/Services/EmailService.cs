using GalaxyExpress.BLL.DTOs.EmailDTOs;
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
    public class EmailService : IEmailService
    {
        private IUnitOfWork _uow;

        public EmailService(IUnitOfWork uow)
        {
            _uow = uow;
        }


        public async Task<Guid> CreateAsync(InsertDTO_Email entity)
        {
            Email email = MappingFunctions.MapSourceToDestination<InsertDTO_Email, Email>(entity); // Mapping with Mapster

            var id = await _uow.Emails.CreateAsync(email);
            await _uow.SaveChangesAsync();

            return id;
        }
        public async Task<IEnumerable<GetDTO_Email>> GetAllAsync()
        {
            // Use Mapster to project one collection onto another
            return MappingFunctions.MapListSourceToDestination<Email, GetDTO_Email>
                (await _uow.Emails.GetAllAsync());
        }
        public async Task<GetDTO_Email?> GetAsync(Guid key)
        {
            Email? email = await _uow.Emails.GetByIdAsync(key);

            GetDTO_Email? emailDTO = MappingFunctions
                .MapSourceToDestination<Email?, GetDTO_Email?>(email); // Mapping with Mapster

            return emailDTO;
        }
        public async Task UpdateAsync(UpdateDTO_Email entity)
        {
            Email email = MappingFunctions.MapSourceToDestination<UpdateDTO_Email, Email>(entity); // Mapping with Mapster

            await _uow.Emails.UpdateAsync(email);
            await _uow.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid key)
        {
            await _uow.Emails.DeleteAsync(key);
            await _uow.SaveChangesAsync();
        }
    }
}
