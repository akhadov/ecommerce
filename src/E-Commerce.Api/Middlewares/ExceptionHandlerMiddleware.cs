using E_Commerce.Service.Exceptions;
using Newtonsoft.Json;
using System.Net;

namespace E_Commerce.Api.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            this._next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (HttpStatusCodeException httpStatusCodeException)
            {
                await HandlerAsync(httpStatusCodeException, httpContext);
            }
            catch (Exception exception)
            {
                await HandlerOtherAsync(exception, httpContext);
            }
        }
        public async Task HandlerAsync(HttpStatusCodeException exception, HttpContext httpContext)
        {
            httpContext.Response.StatusCode = (int)exception.StatusCode;
            httpContext.Response.ContentType = "application/json";
            string json =
                JsonConvert.SerializeObject(new { StatusCode = exception.StatusCode, Message = exception.Message });

            await httpContext.Response.WriteAsync(json);
        }
        public async Task HandlerOtherAsync(Exception exception, HttpContext httpContext)
        {
            httpContext.Response.StatusCode = 500;
            httpContext.Response.ContentType = "application/json";
            string json =
                JsonConvert.SerializeObject(new { StatusCode = HttpStatusCode.InternalServerError, Message = exception.Message });

            await httpContext.Response.WriteAsync(json);
        }
    }
}
