using AspnetMicroservices.Ordering.Domain.Entities;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetMicroservices.Ordering.Infrastructure.Persistence
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext orderContext, ILogger<OrderContextSeed> logger)
        {
            if (!orderContext.Orders.Any())
            {
                orderContext.Orders.AddRange(GetPreconfiguredOrders());

                await orderContext.SaveChangesAsync();

                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(OrderContext).Name);
            }
        }

        private static IEnumerable<Order> GetPreconfiguredOrders()
        {
            return new List<Order>
            {
                new Order {UserName = "leo", FirstName = "Leonardo", LastName = "Dias", EmailAddress = "Ldosrj2010@gmail.com", AddressLine = "Rio de Janeiro", Country = "Brazil", TotalPrice = 350 }
            };
        }
    }
}
