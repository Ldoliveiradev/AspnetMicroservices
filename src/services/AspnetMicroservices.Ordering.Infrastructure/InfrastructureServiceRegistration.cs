using AspnetMicroservices.Ordering.Application.Contracts.Infrastructure;
using AspnetMicroservices.Ordering.Application.Contracts.Persistence;
using AspnetMicroservices.Ordering.Application.Models;
using AspnetMicroservices.Ordering.Infrastructure.Mail;
using AspnetMicroservices.Ordering.Infrastructure.Persistence;
using AspnetMicroservices.Ordering.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspnetMicroservices.Ordering.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OrderContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("OrderingConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IOrderRepository, OrderRepository>();

            services.Configure<EmailSettings>(c => configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}
