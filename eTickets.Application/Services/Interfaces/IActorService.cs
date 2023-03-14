using eTickets.Domains.Models;

namespace eTickets.Application.Services.Interfaces
{
    public interface IActorService
    {
        Task<List<Actor>> GetAllListAsync(CancellationToken cancellationToken);
        Task<Actor> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task AddAsync(Actor actor, CancellationToken cancellationToken);
        Task<Actor> UpdateAsync(int id, Actor newActor, CancellationToken cancellationToken);
        Task DeleteAsync(int id, CancellationToken cancellationToken);
    }
}
