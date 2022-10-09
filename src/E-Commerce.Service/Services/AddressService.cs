using E_Commerce.Domain.Configurations;
using E_Commerce.Domain.Entities.Addresses;
using E_Commerce.Service.DTOs.Addresses;
using E_Commerce.Service.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Service.Services
{
    public class AddressService : IAddressService
    {
        public Task<Address> AddAsync(AddressForCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Address, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Address>> GetAllAsync(PaginationParams @params, Expression<Func<Address, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<Address> GetAsync(Expression<Func<Address, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Address> UpdateAsync(long id, AddressForCreateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
