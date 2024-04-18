using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.DTOs.PaymentCardDTOs
{
    public class GetDTO_PaymentCard
    {
        public Guid CardId { get; set; }
        public string CardNumber { get; set; } = default!;
        public string Validity { get; set; } = default!;
        public string CVV { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
