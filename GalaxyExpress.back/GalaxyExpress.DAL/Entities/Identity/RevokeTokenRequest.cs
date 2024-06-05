using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Entities.Identity
{
    public class RevokeTokenRequest
    {
        public string Token { get; set; } = default!;
    }
}
