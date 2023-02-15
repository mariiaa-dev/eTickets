using eTicketsCustomMiddleware.UnhandledExceptions;
using Microsoft.AspNetCore.Builder;

namespace eTicketsCustomMiddleware.UnhandledExceptions.Extensions
{
    public static class CustomExceptionHandlerMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExceptionHandlerMiddleware>();
        }
    }
}