using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Addresses;
using E_Commerce.Service.DTOs.Addresses;
using System.Linq.Expressions;

namespace E_Commerce.Service.Interfases
{
    public interface IAddressService
    {
        Task<Address> AddAsync(AddressForCreateDto dto);
        Task<Address> UpdateAsync(long id, AddressForPutDto dto);
        Task<Address> UpdateAsync(long id, AddressForPatchDto dto);
        Task<bool> DeleteAsync(Expression<Func<Address, bool>> expression);
        Task<AddressForViewAllDto> GetAsync(Expression<Func<Address, bool>> expression);
        Task<IEnumerable<Address>> GetAllAsync(Expression<Func<Address, bool>>? expression = null,
        PaginationParams? parameters = null);
    }
}
