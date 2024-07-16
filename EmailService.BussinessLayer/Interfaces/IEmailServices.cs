using EmailService.BussinessLayer.Dtos;

namespace EmailService.BussinessLayer.Interfaces
{
    public interface IEmailServices
    {
        Task<bool> SendEmailAsync(EmailRequest emailRequest);
    }
}
