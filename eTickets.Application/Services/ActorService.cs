using eTickets.Application.Services.Interfaces;
using eTickets.Domains.Models;
using eTickets.Persistence.Repository.Interfaces.Base;

namespace eTickets.Application.Services
{
    internal class ActorService : IActorService
    {
        private readonly IEntityBaseRepository<Actor> _repository;

        public ActorService(IEntityBaseRepository<Actor> actorRepository) => _repository = actorRepository;

        public async Task AddAsync(Actor actor, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(actor, cancellationToken);
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(id, cancellationToken);
        }

        public Task<List<Actor>> GetAllListAsync(CancellationToken cancellationToken)
        {
            return _repository.GetAllListAsync(cancellationToken);
        }

        public async Task<Actor?> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsync(id, cancellationToken);
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor, CancellationToken cancellationToken)
        {
            return await _repository.UpdateAsync(id, newActor, cancellationToken);
        }
    }
}
