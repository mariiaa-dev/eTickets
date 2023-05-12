using eTickets.Application.Services.Interfaces;
using eTickets.Domains.Models;
using eTickets.Persistence.Repository.Interfaces.Base;

namespace eTickets.Application.Services
{
    internal class ProducerService : IProducerService
    {
        private readonly IEntityBaseRepository<Producer> _repository;

        public ProducerService(IEntityBaseRepository<Producer> actorRepository) => _repository = actorRepository;

        public async Task AddAsync(Producer entity, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(entity, cancellationToken);
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(id, cancellationToken);
        }

        public Task<List<Producer>> GetAllListAsync(CancellationToken cancellationToken)
        {
            return _repository.GetAllListAsync(cancellationToken);
        }

        public async Task<Producer?> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsync(id, cancellationToken);
        }

        public async Task<Producer> UpdateAsync(int id, Producer entity, CancellationToken cancellationToken)
        {
            return await _repository.UpdateAsync(id, entity, cancellationToken);
        }
    }
}
