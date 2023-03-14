using eTickets.Domains.Models;
using eTickets.Persistence.Context.Interfaces;
using eTickets.Persistence.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Persistence.Repository
{
    internal class ActorRepository : IActorRepository
    {
        private readonly IAppDbContext _context;

        public ActorRepository(IAppDbContext context) => _context = context;

        public Task<List<Actor>> GetAllListAsync(CancellationToken cancellationToken)
        {
            return _context.Actors.ToListAsync(cancellationToken);
        }
    }
}
