using eTickets.Application.Services.Interfaces;
using eTickets.Domains.Models;
using eTickets.Persistence.Repository.Interfaces;

namespace eTickets.Application.Services
{
    internal class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;

        public ActorService(IActorRepository actorRepository) => _actorRepository = actorRepository;

        public Task<List<Actor>> GetActorsListAsync(CancellationToken cancellationToken)
        {
            return _actorRepository.GetActorsListAsync(cancellationToken);
        }
    }
}
