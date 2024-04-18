using GalaxyExpress.BLL.DTOs.PhoneNumberDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.Services.Interfaces
{
    public interface IPhoneNumberService : IGenericService<Guid, GetDTO_PhoneNumber, InsertDTO_PhoneNumber, UpdateDTO_PhoneNumber>
    {
    }
}
