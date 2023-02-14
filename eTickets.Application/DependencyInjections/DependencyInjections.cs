using eTickets.Application.Services;
using eTickets.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace eTickets.Application.DependencyInjections
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IActorService, ActorService>();
            services.AddScoped<IProducerService, ProducerService>();
            services.AddScoped<ICinemaService, CinemaService>();

            return services;
        }
    }
}
