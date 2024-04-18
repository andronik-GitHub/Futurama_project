using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.DTOs.UserDTOs
{
    public class UpdateDTO_User
    {
        public Guid UserId { get; set; }
        public Dictionary<string, string> Values { get; set; } = default!;
    }
}
