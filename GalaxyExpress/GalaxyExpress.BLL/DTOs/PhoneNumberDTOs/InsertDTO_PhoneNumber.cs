using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.DTOs.PhoneNumberDTOs
{
    public class InsertDTO_PhoneNumber
    {
        public string Number { get; set; } = default!;
        public Guid UserId { get; set; }
    }
}
