using eTickets.Persistence.Context;
using eTickets.Persistence.Repository;
using eTickets.Persistence.Repository.Base;
using eTickets.Persistence.Repository.Interfaces;
using eTickets.Persistence.Repository.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped(typeof(IEntityBaseRepository<>), typeof(EntityBaseRepository<>));

            return services;
        }
    }
}
