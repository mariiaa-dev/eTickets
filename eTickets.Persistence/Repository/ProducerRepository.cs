using eTickets.Domains.Models;
using eTickets.Persistence.Context;
using eTickets.Persistence.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Persistence.Repository
{
    public class ProducerRepository : IProducerRepository
    {
        private readonly AppDbContext _context;

        public ProducerRepository(AppDbContext context) => _context = context;

        public Task<List<Producer>> GetProducersListAsync(CancellationToken cancellationToken)
        {
            return _context.Producers.ToListAsync(cancellationToken);
        }
    }
}
