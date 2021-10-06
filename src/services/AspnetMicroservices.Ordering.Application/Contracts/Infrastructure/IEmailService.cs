using AspnetMicroservices.Ordering.Application.Models;
using System.Threading.Tasks;

namespace AspnetMicroservices.Ordering.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
