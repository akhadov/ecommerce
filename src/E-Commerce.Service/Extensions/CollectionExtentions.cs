using E_Commerce.Domain.Configurations;
using Newtonsoft.Json;
using static E_Commerce.Service.Helpers.HttpContextHelper;

namespace E_Commerce.Service.Extensions
{
    public static class CollectionExtentions
    {
        public static IEnumerable<T> ToPagedAsEnumerable<T>(this IEnumerable<T> source, PaginationParams? parameters)
        where T : class
        {
            return Pagination(source.AsQueryable(), parameters);
        }

        public static IQueryable<T> ToPagedAsQueryable<T>(this IQueryable<T> source,
            PaginationParams? parameters = null)
            where T : class
        {
            return Pagination(source, parameters);
        }

        private static IQueryable<T> Pagination<T>(IQueryable<T> source, PaginationParams? parameters)
        {
            if (parameters is null || parameters.PageSize < 1 || parameters.PageIndex < 1)
                parameters = new PaginationParams { PageSize = 20, PageIndex = 1 };

            var paginationMetaData = new PaginationMetaData(source.Count(), parameters.PageSize, parameters.PageIndex);

            if (ResponseHeaders.ContainsKey("X-Pagination"))
                ResponseHeaders.Remove("X-Pagination");

            ResponseHeaders.Add("X-Pagination", JsonConvert.SerializeObject(paginationMetaData));
            ResponseHeaders.Add("Access-Control-Expose-Headers", "X-Pagination");

            return source.Skip(parameters.PageSize * (parameters.PageIndex - 1)).Take(parameters.PageSize);
        }
    }
}
