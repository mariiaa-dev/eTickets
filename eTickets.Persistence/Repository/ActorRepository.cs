using eTickets.Domains.Models;
using eTickets.Persistence.Context;
using eTickets.Persistence.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Persistence.Repository
{
    internal class ActorRepository : IActorRepository
    {
        private readonly AppDbContext _context;

        public ActorRepository(AppDbContext context) => _context = context;

        public Task<List<Actor>> GetAllListAsync(CancellationToken cancellationToken)
        {
            return _context.Actors.ToListAsync(cancellationToken);
        }
    }
}
