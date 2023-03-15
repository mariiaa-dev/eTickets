using eTickets.Extensions.Middleware.UnhandledExceptions;
using Microsoft.AspNetCore.Builder;

namespace eTickets.Extensions.Middleware.UnhandledExceptions.Extensions
{
    public static class CustomExceptionHandlerMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExceptionHandlerMiddleware>();
        }
    }
}