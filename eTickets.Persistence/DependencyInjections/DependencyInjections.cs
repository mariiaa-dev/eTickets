using eTickets.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eTickets.Persistence.DependencyInjections
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder();

            var path = "C:\\Users\\User\\source\\repos\\eTickets\\eTickets\\appsettings.json";
            builder.AddJsonFile(path);
            configuration = builder.Build();

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
