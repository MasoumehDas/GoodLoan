using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class UserRequstMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        

        public UserRequstMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<UserRequstMiddleware>();
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                //مسیر رفت
               
                await _next(context);
                //مسیر برگشت
            }
            finally
            {
                _logger.LogError(
                    "Request {method} {url} => {statusCode}",
                    context.Request?.Method,
                    context.Request?.Path.Value,
                    context.Response?.StatusCode);
               
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class UserRequstMiddlewareExtensions
    {
        public static IApplicationBuilder UseUserRequstMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<UserRequstMiddleware>();
        }
    }
}
