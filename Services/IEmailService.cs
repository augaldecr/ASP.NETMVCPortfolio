using Portfolio.Models;

namespace Portfolio.Services
{
    public interface IEmailService
    {
        Task Send(ContactViewModel contact);
    }
}