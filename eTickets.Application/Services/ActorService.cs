using eTickets.Application.Services.Interfaces;
using eTickets.Domains.Models;
using eTickets.Persistence.Repository.Interfaces;

namespace eTickets.Application.Services
{
    internal class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;

        public ActorService(IActorRepository actorRepository) => _actorRepository = actorRepository;

        public Task AddAsync(Actor actor, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Actor>> GetAllListAsync(CancellationToken cancellationToken)
        {
            return _actorRepository.GetAllListAsync(cancellationToken);
        }

        public Task<Actor> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Actor> UpdateAsync(int id, Actor newActor, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
