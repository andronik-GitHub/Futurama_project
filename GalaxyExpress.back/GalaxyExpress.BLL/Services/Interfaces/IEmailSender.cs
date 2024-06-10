using GalaxyExpress.DAL.Entities.Identity.ResetPassword;

namespace GalaxyExpress.BLL.Services.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(Message message);
    }
}
