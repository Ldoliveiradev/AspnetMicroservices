using AspnetMicroservices.Basket.API.Entities;
using AspnetMicroservices.EventBus.Messages.Events;
using AutoMapper;

namespace AspnetMicroservices.Basket.API.Mapper
{
    public class BasketProfile : Profile
    {
        public BasketProfile()
        {
            CreateMap<BasketCheckout, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
