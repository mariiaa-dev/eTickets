using eTickets.Domains.Models;

namespace eTickets.Persistence.Repository.Interfaces
{
    internal interface IProducerRepository
    {
        Task<List<Producer>> GetProducersListAsync(CancellationToken cancellationToken);
    }
}
