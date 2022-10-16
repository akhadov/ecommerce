using System.Net;

namespace E_Commerce.Service.Exceptions
{
    public class NotFoundException : HttpStatusCodeException
    {
        public NotFoundException(string entityName)
            : base(HttpStatusCode.NotFound, $"{entityName} not found!")
        {
        }
    }
}
