using eTickets.Application.Services.Interfaces;
using eTickets.Domains.Models;
using eTickets.Persistence.Repository.Interfaces.Base;

namespace eTickets.Application.Services
{
    internal class ProducerService : IProducerService
    {
        private readonly IEntityBaseRepository<Producer> _repository;

        public ProducerService(IEntityBaseRepository<Producer> actorRepository) => _repository = actorRepository;

        public Task AddAsync(Producer entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Producer>> GetAllListAsync(CancellationToken cancellationToken)
        {
            return _repository.GetAllListAsync(cancellationToken);
        }

        public Task<Producer?> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Producer> UpdateAsync(int id, Producer entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
