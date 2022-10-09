using System.Net;

namespace E_Commerce.Service.Exceptions
{
    public class StatusCodeException : Exception
    {
        private readonly HttpStatusCode _statusCode;

        public StatusCodeException(HttpStatusCode statusCode, string message)
            : base(message)
        {
            this._statusCode = statusCode;
        }
    }
}
