using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.DTOs.PaymentCardDTOs
{
    public class InsertDTO_PaymentCard
    {
        public string CardNumber { get; set; } = default!;
        public string Validity { get; set; } = default!;
        public string CVV { get; set; } = default!;
        public Guid UserId { get; set; }
    }
}
