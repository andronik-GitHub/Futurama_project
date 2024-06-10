using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.DTOs.UserDTOs
{
    public class AddEmailToUser
    {
        public Guid UserId { get; set; } 
        public string Email { get; set; } = default!;
    }
}
