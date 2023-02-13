using eTickets.Initializer.Initializer;
using eTickets.Persistence.Context.Interfaces;
using eTickets.Persistence.Context;
using Microsoft.Extensions.DependencyInjection;

namespace eTickets.Initializer.DependencyInjections
{
    public static class DependencyInjections
    {
        public static IServiceCollection Initialize(this IServiceCollection services)
        {
            services.AddScoped<IAppDbContext, AppDbContext>()
                .AddScoped<DbInitializer>();

            services.BuildServiceProvider()
                .GetService<DbInitializer>()
                ?.Initialize();

            return services;
        }
    }
}
