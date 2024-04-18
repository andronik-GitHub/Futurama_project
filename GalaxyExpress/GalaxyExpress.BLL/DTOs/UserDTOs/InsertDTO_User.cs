using GalaxyExpress.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.DTOs.UserDTOs
{
    public class InsertDTO_User
    {
        public string Login { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string? FatherName { get; set; }
        public DateTime? Birthday { get; set; }
        public Gender? Sex { get; set; }
    }
}
