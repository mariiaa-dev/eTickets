using eTickets.Domains.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Persistence.Repository.Interfaces
{
    public interface IActorRepository
    {
        Task<List<Actor>> GetActorsListAsync(CancellationToken cancellationToken);
    }
}
