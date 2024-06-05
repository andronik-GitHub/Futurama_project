using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;

namespace GalaxyExpress.DAL.Entities.Identity
{
    [Owned]
    public class RefreshToken
    {
        [Required]
        public string Token { get; set; } = default!;
        public DateTime Expires { get; set; }
        private bool IsExpired => DateTime.UtcNow >= Expires;
        public DateTime Created { get; set; }
        public DateTime? Revoked { get; set; }
        public bool IsActive => Revoked == null && !IsExpired;
    }
}
