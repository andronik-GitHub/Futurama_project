﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.DTOs.EmailDTOs
{
    public class InsertDTO_Email
    {
        public string EmailAddress { get; set; } = default!;
        public Guid UserId { get; set; }
    }
}
