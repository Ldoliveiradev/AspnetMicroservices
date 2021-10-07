using AspnetMicroservices.Ordering.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspnetMicroservices.Ordering.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
    }
}
