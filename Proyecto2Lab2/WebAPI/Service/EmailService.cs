// using SendGrid's C# Library
// https://github.com/sendgrid/sendgrid-csharp
using Entities_POJO;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;


namespace WebAPI.Service
{
    public class EmailService
    {

        public EmailService(Email email)
        {
            Execute(email).Wait();
        }

        //private static void Main()
        //{
        //    Execute().Wait();
        //}


        //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

        static async Task Execute(Email email)
        {
            var apiKey = Environment.GetEnvironmentVariable("SendGridEnv");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("test@example.com", "Example User");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("mpinedal@ucenfotec.ac.cr", "Example User");
            var plainTextContent = $" {email.Owner}, {email.Content}, {email.EmailAddress}";
            var htmlContent = $"<strong> {email.Owner} and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }


    }
}