using AutoMapper;
using E_Commerce.Domain.Entities.Addresses;
using E_Commerce.Domain.Entities.Orders;
using E_Commerce.Domain.Entities.Payments;
using E_Commerce.Domain.Entities.Products;
using E_Commerce.Domain.Entities.Users;
using E_Commerce.Service.DTOs.Addresses;
using E_Commerce.Service.DTOs.Orders;
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
            CreateMap<UserForCreateDto, User>();
            CreateMap<User, UserFullViewDto>();

            CreateMap<CategoryForCreateDto, Category>();
            CreateMap<Category, CategoryFullViewDto>();
            CreateMap<CategoryPutDto, Category>();


            CreateMap<ReviewForCreateDto, Review>();
            CreateMap<Review, ReviewForFullViewDto>();
            CreateMap<ReviewForPatchDto, Review>();
            CreateMap<ReviewForPutDto, Review>();


            CreateMap<PaymentForCreateDto, Payment>();
            CreateMap<Payment, PaymentForFullViewDto>();
            CreateMap<PaymentForPatchDto, Payment>();
            CreateMap<PaymentForPutDto, Payment>();

            CreateMap<OrderDetailForCreateDto, Order>();
            CreateMap<OrderDetail, OrderDetailForFullViewDto>();
            CreateMap<OrderDetailForPatchDto, OrderDetail>();
            CreateMap<OrderDetailForPutDto, OrderDetail>();

            CreateMap<OrderForCreateDto, Order>();
            CreateMap<Order, OrderForFullViewDto>();
            CreateMap<OrderForPatchDto, Order>();
            CreateMap<OrderForPutDto, Order>();

            CreateMap<AddressForCreateDto, Address>();
            CreateMap<Address, AddressForViewAllDto>();
            CreateMap<AddressForPatchDto, Address>();
            CreateMap<AddressForPutDto, Address>();
        }
    }
}
