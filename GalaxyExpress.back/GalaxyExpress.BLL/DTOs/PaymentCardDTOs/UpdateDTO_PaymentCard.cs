using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.DTOs.PaymentCardDTOs
{
    public class UpdateDTO_PaymentCard
    {
        public Guid CardId { get; set; }
        public string CardNumber { get; set; } = default!;
        public string Validity { get; set; } = default!;
        public string CVV { get; set; } = default!;
        public Guid UserId { get; set; }
    }
}
