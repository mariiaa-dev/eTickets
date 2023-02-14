using eTickets.Domains.Models;

namespace eTickets.Application.Services.Interfaces
{
    public interface IActorService
    {
        Task<List<Actor>> GetActorsListAsync(CancellationToken cancellationToken);
    }
}
