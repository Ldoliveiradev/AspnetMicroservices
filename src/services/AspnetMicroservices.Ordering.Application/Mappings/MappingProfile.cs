using AspnetMicroservices.Ordering.Application.Features.Orders.Queries.GetOrdersList;
using AspnetMicroservices.Ordering.Domain.Entities;
using AutoMapper;

namespace AspnetMicroservices.Ordering.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrdersViewModel>().ReverseMap();
        }
    }
}
