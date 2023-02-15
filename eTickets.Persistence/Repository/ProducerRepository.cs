using eTickets.Domains.Models;
using eTickets.Persistence.Context.Interfaces;
using eTickets.Persistence.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Persistence.Repository
{
    public class ProducerRepository : IProducerRepository
    {
        private readonly IAppDbContext _context;

        public ProducerRepository(IAppDbContext context) => _context = context;

        public Task<List<Producer>> GetProducersListAsync(CancellationToken cancellationToken)
        {
            return _context.Producers.ToListAsync(cancellationToken);
        }
    }
}
