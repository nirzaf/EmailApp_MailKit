using System.Threading.Tasks;

namespace EmailService
{
    public interface IEmailSender
    {
        Task SendEmailAsync(Message message);
    }
}
