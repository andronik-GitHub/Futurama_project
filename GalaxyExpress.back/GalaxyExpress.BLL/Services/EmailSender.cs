using GalaxyExpress.BLL.Services.Interfaces;
using GalaxyExpress.DAL.Entities.Identity.ResetPassword;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace GalaxyExpress.BLL.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly SendEmailConfiguration _sendEmailConfiguration;

        public EmailSender(SendEmailConfiguration sendEmailConfiguration)
        {
            _sendEmailConfiguration = sendEmailConfiguration;
        }


        public async Task SendEmailAsync(Message message)
        {
            var emailMessage = CreateEmailMessage(message);

            await SendAsync(emailMessage);
        }


        private MimeMessage CreateEmailMessage(Message message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("email", _sendEmailConfiguration.From));
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject = message.Subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = message.Content };


            var bodyBuilder = new BodyBuilder { HtmlBody = message.Content };
            emailMessage.Body = bodyBuilder.ToMessageBody();

            return emailMessage;
        }
        private async Task SendAsync(MimeMessage mailMessage)
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    client.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                    await client.ConnectAsync(_sendEmailConfiguration.SmtpServer, _sendEmailConfiguration.Port, SecureSocketOptions.StartTls);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    await client.AuthenticateAsync(_sendEmailConfiguration.UserName, _sendEmailConfiguration.Password);

                    await client.SendAsync(mailMessage);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Errors: {ex.Message}");
                }
                finally
                {
                    await client.DisconnectAsync(true);
                    client.Dispose();
                }
            }
        }
    }
}
