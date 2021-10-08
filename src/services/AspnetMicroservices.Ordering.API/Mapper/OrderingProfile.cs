using AspnetMicroservices.EventBus.Messages.Events;
using AspnetMicroservices.Ordering.Application.Features.Orders.Commands.CheckoutOrder;
using AutoMapper;

namespace AspnetMicroservices.Ordering.API.Mapper
{
    public class OrderingProfile : Profile
    {
        public OrderingProfile()
        {
            CreateMap<CheckoutOrderCommand, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
