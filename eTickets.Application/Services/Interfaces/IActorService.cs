using eTickets.Domains.Models;

namespace eTickets.Application.Services.Interfaces
{
    internal interface IActorService
    {
        Task<List<Actor>> GetActorsListAsync(CancellationToken cancellationToken);
    }
}
