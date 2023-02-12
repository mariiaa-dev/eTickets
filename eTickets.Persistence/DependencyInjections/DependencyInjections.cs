using eTickets.Application.Context;
using eTickets.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using eTickets.Initializer.Initializer;

namespace eTickets.Persistence.DependencyInjections
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, string path)
        {
            var builder = new ConfigurationBuilder();

            builder.AddJsonFile(path);
            var config = builder.Build();

            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IAppDbContext, AppDbContext>()
                .AddScoped<DbInitializer>();

            services.BuildServiceProvider()
                .GetService<DbInitializer>()
                ?.Initialize();

            return services;
        }
    }
}
