using Portfolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portfolio.Services
{
    public class EmailServiceSendGrid : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailServiceSendGrid(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task Send(ContactViewModel contact)
        {
            var apiKey = _configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = _configuration.GetValue<string>("SENDGRID_FROM");
            var name = _configuration.GetValue<string>("SENDGRID_NAME");

            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(email, name);
            var subject = $"The client { contact.From} is looking to contact you";
            var to = new EmailAddress(email, name);
            var messagePlainText = contact.Message;
            var htmlContent = @$"From: {contact.Name} - 
                                   Email: {contact.From}
                                   Message: {contact.Message}";
            var singleEmail = MailHelper.CreateSingleEmail(from, to, subject,
                                messagePlainText, htmlContent);
            var response = await client.SendEmailAsync(singleEmail);
        }
    }
}
