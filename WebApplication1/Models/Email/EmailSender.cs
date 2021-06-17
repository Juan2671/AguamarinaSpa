using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace WebApplication1.Models.Email
{
    public interface IEmailSenderP
    {
            Task SendEmailAsync(string email, string subject, string message);
    }
    public class EmailSender : IEmailSenderP
    {
        private readonly SmtpConfig _emailSettings;

        public EmailSender(IOptions<SmtpConfig> smtpSettings) {
            _emailSettings = smtpSettings.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            try
            {
                var mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress(_emailSettings.SenderName, _emailSettings.SenderEmail));
                mimeMessage.To.Add(new MailboxAddress(email));
                mimeMessage.Subject = subject;
                mimeMessage.Body = new TextPart("html")
                {
                    Text = message
                };

                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    await client.ConnectAsync(_emailSettings.Server, _emailSettings.Port, true);

                    await client.AuthenticateAsync(_emailSettings.Usarname, _emailSettings.Password);
                    await client.SendAsync(mimeMessage);
                    await client.DisconnectAsync(true);
                }
            }
            catch (Exception ex){
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}
