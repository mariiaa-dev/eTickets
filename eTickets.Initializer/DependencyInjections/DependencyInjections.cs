using eTickets.Initializer.Initializer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace eTickets.Initializer.DependencyInjections
{
    public static class DependencyInjections
    {
        public static IServiceCollection Initialize(this IServiceCollection services)
        {
            services.AddScoped<DbInitializer>();

            var httpContextAccessor = services.BuildServiceProvider().GetService<IHttpContextAccessor>();

            services.BuildServiceProvider()
                .GetService<DbInitializer>()
                ?.InitializeAsync(httpContextAccessor?.HttpContext?.RequestAborted ?? CancellationToken.None);

            return services;
        }
    }
}