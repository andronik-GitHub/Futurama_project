using GalaxyExpress.BLL.DTOs.EmailDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.Services.Interfaces
{
    public interface IEmailService : IGenericService<Guid, GetDTO_Email, InsertDTO_Email, UpdateDTO_Email>
    {
    }
}
