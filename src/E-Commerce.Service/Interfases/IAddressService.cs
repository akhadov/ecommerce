using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Addresses;
using E_Commerce.Domain.Entities.Users;
using E_Commerce.Service.DTOs.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Service.Interfases
{
    public interface IAddressService
    {
        Task<Address> AddAsync(AddressForCreateDto dto);
        Task<Address> UpdateAsync(long id, AddressForCreateDto dto);
        Task<bool> DeleteAsync(Expression<Func<Address, bool>> expression);
        Task<Address> GetAsync(Expression<Func<Address, bool>> expression);
        Task<IEnumerable<Address>> GetAllAsync(PaginationParams @params, Expression<Func<Address, bool>> expression = null);
    }
}
