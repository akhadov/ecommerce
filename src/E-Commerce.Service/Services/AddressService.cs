using AutoMapper;
using E_Commerce.Data.IRepositories;
using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Addresses;
using E_Commerce.Domain.Enums;
using E_Commerce.Service.DTOs.Addresses;
using E_Commerce.Service.Exceptions;
using E_Commerce.Service.Extensions;
using E_Commerce.Service.Interfases;
using System.Linq.Expressions;

namespace E_Commerce.Service.Services
{
    public class AddressService : IAddressService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AddressService(IUnitOfWork unitOfwork, IMapper mapper)
        {
            this._unitOfWork = unitOfwork;
            this._mapper = mapper;
        }
        public async Task<Address> AddAsync(AddressForCreateDto dto)
        {
            var mappedAddress = _mapper.Map<Address>(dto);
            var address = await _unitOfWork.Addresses.AddAsync(mappedAddress);

            await _unitOfWork.SaveChangesAsync();

            return address;
        }

        public async Task<bool> DeleteAsync(Expression<Func<Address, bool>> expression)
        {
            var adress = await _unitOfWork.Addresses.GetAsync(expression);
            if (adress is null)
                throw new NotFoundException("Address");

            adress.State = ItemState.Deleted;
            adress.Update();

            await _unitOfWork.SaveChangesAsync();

            return true;
        }

        public Task<IEnumerable<Address>> GetAllAsync(Expression<Func<Address, bool>>? expression = null, PaginationParams? parameters = null)
        {
            return Task.FromResult<IEnumerable<Address>>(
            (expression is null ? _unitOfWork.Addresses.GetAll(expression, isTracking: false) : _unitOfWork.Addresses.GetAll(expression, isTracking: false))
            .ToPagedAsQueryable(parameters));
        }

        public async Task<AddressForViewAllDto> GetAsync(Expression<Func<Address, bool>> expression)
        {
            var address = await _unitOfWork.Addresses.GetAsync(expression);
            if (address is null)
                throw new NotFoundException("Address");

            return _mapper.Map<AddressForViewAllDto>(address);
        }

        public async Task<Address> UpdateAsync(long id, AddressForPutDto dto)
        {
            var address = await _unitOfWork.Addresses.GetAsync(p => p.Id == id);
            if (address is null)
                throw new NotFoundException("Address");

            address = _mapper.Map(dto, address);

            address.State = ItemState.Updated;
            address.Update();

            address = await _unitOfWork.Addresses.UpdateAsync(address);

            await _unitOfWork.SaveChangesAsync();

            return address;
        }

        public async Task<Address> UpdateAsync(long id, AddressForPatchDto dto)
        {
            var address = await _unitOfWork.Addresses.GetAsync(p => p.Id == id);
            if (address is null)
                throw new NotFoundException("Address");

            if (dto.ShippingCity is not null)
                address.ShippingCity = dto.ShippingCity;
            if (dto.ShippingAddress is not null)
                address.ShippingAddress = dto.ShippingAddress;
            if (dto.ShippingCountry is not null)
                address.ShippingCountry = dto.ShippingCountry;
            if (dto.PostalCode is not null)
                address.PostalCode = dto.PostalCode;

            address.State = ItemState.Updated;
            address.Update();

            address = await _unitOfWork.Addresses.UpdateAsync(address);

            await _unitOfWork.SaveChangesAsync();

            return address;
        }
    }
}
