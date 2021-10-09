using AspnetMicroservices.Shopping.Aggregator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspnetMicroservices.Shopping.Aggregator.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}
