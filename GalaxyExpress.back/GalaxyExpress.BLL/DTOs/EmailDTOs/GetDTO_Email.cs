using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.DTOs.EmailDTOs
{
    public class GetDTO_Email
    {
        public Guid EmailId { get; set; }
        public string EmailAddress { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
