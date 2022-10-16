using AutoMapper;
using E_Commerce.Domain.Entities.Addresses;
using E_Commerce.Domain.Entities.Orders;
using E_Commerce.Domain.Entities.Payments;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Domain.Entities.Users;
using E_Commerce.Service.DTOs.Addresses;
using E_Commerce.Service.DTOs.Orders.OrderDetails;
using E_Commerce.Service.DTOs.Payments;
using E_Commerce.Service.DTOs.Products.Categories;
using E_Commerce.Service.DTOs.Products.Reviews;
using E_Commerce.Service.DTOs.Users;

namespace E_Commerce.Service.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserForCreateDto, User>().ReverseMap();
            CreateMap<CategoryForCreateDto, Category>().ReverseMap();
            CreateMap<ReviewForCreateDto, Review>().ReverseMap();
            CreateMap<PaymentForCreateDto, Payment>().ReverseMap();
            CreateMap<OrderDetailForCreateDto, Order>().ReverseMap();
            CreateMap<OrderDetailForCreateDto, Order>().ReverseMap();
            CreateMap<AddressForCreateDto, Address>().ReverseMap();
        }
    }
}
