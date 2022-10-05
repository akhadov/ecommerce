using E_Commerce.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Data.Repositories
{
    public class GenericRepository<TSource> : IGenericRepository<TSource> where TSource : class
    {
    }
}
