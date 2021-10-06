using AspnetMicroservices.Discount.Grpc.Entities;
using AspnetMicroservices.Discount.Grpc.Protos;
using AutoMapper;

namespace AspnetMicroservices.Discount.Grpc.Mapper
{
    public class DiscountProfile : Profile
    {
        public DiscountProfile()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}
