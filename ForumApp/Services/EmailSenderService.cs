using Microsoft.AspNetCore.Identity.UI.Services;

namespace ForumApp.Services
{
    public class EmailSenderService : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //TODO Создать email service
            await Task.CompletedTask;
        } 
    }
}
