using eTickets.Application.Context;
using eTickets.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eTickets.Persistence.DependencyInjections
{
    public static class DependencyInjections
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "EF1001:Internal EF Core API usage.", Justification = "<Pending>")]
        public static IServiceCollection AddPersistence(this IServiceCollection services, string path)
        {
            var builder = new ConfigurationBuilder();

#pragma warning disable CS8634
#pragma warning disable CS8621
            services.AddScoped<IAppDbContext, AppDbContext>()
                .AddScoped(provider =>
                provider.GetService<DbSetInitializer>());
#pragma warning restore CS8621
#pragma warning restore CS8634

            builder.AddJsonFile(path);
            var config = builder.Build();

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
