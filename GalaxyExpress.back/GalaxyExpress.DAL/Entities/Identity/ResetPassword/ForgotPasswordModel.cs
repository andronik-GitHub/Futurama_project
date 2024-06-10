using System.ComponentModel.DataAnnotations;

namespace GalaxyExpress.DAL.Entities.Identity.ResetPassword
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = default!;
    }
}
