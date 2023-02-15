using eTickets.Application.Services.Interfaces;
using eTickets.Domains.Models;
using eTickets.Persistence.Repository.Interfaces;

namespace eTickets.Application.Services
{
    internal class ProducerService : IProducerService
    {
        private readonly IProducerRepository _producerReposiory;

        public ProducerService(IProducerRepository producerReposiory) => _producerReposiory = producerReposiory;

        public Task<List<Producer>> GetProducersListAsync(CancellationToken cancellationToken)
        {
            return _producerReposiory.GetProducersListAsync(cancellationToken);
        }
    }
}
