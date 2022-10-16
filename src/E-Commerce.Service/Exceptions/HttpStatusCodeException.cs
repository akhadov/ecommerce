﻿using System.Net;

namespace E_Commerce.Service.Exceptions
{
    public class HttpStatusCodeException : Exception
    {
        public HttpStatusCodeException(int statusCode, string message)
            : base(message)
        {
            StatusCode = statusCode;
        }

        public HttpStatusCodeException(HttpStatusCode statusCode, string message)
            : this((int)statusCode, message)
        {
        }

        public int StatusCode { get; }
    }
}
