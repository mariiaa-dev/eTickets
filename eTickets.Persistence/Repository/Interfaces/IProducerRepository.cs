using eTickets.Domains.Models;

namespace eTickets.Persistence.Repository.Interfaces
{
    public interface IProducerRepository
    {
        Task<List<Producer>> GetAllListAsync(CancellationToken cancellationToken);
    }
}
