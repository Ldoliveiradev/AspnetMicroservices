using AspnetMicroservices.Shopping.Aggregator.Models;
using System.Threading.Tasks;

namespace AspnetMicroservices.Shopping.Aggregator.Services
{
    public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);
    }
}
