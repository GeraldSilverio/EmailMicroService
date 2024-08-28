using EmailService.Dtos;

namespace EmailService.Interfaces
{
    public interface IEmailServices
    {
        Task<bool> SendEmailAsync(EmailRequest emailRequest);
    }
}
