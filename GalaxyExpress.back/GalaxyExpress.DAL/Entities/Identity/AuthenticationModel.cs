using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Entities.Identity
{
    public class AuthenticationModel
    {
        public string Message { get; set; } = default!;
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; } = default!;
        public List<string> Emails { get; set; } = new List<string>();
        public List<string> PhoneNumbers { get; set; } = new List<string>();
        public List<string> Roles { get; set; } = new List<string>();
        public string Token { get; set; } = default!;
        [JsonIgnore]
        public string RefreshToken { get; set; } = default!;
        public DateTime RefreshTokenExpiration {  get; set; } = default!;
    }
}
