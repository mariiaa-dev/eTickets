using eTickets.Domains.Models;

namespace eTickets.Persistence.Repository.Interfaces
{
    public interface ICinemaRepository
    {
        Task<List<Cinema>> GetCinemasListAsync(CancellationToken cancellationToken);
    }
}
