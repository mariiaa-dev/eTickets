using eTickets.Domains.Models;

namespace eTickets.Application.Services.Interfaces
{
    public interface IProducerService
    {
        Task<List<Producer>> GetAllListAsync(CancellationToken cancellationToken);
    }
}
