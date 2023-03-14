using eTickets.Domains.Models;

namespace eTickets.Persistence.Repository.Interfaces
{
    public interface ICinemaRepository
    {
        Task<List<Cinema>> GetAllListAsync(CancellationToken cancellationToken);
    }
}
