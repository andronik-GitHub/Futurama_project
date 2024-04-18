﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.DTOs.PhoneNumberDTOs
{
    public class GetDTO_PhoneNumber
    {
        public Guid PhoneNumberId { get; set; }
        public string Number { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
