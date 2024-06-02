using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.DTOs.UserDTOs
{
    public class GetDTO_User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; } = default!;
        public string Login { get; set; } = default!;
        public IEnumerable<string> Emails { get; set; } = default!;
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
