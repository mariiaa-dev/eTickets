using eTickets.Domains.Models;
using eTickets.Persistence.Context;
using eTickets.Persistence.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Persistence.Repository
{
    internal class CinemaRepository : ICinemaRepository
    {
        private readonly AppDbContext _context;

        public CinemaRepository(AppDbContext context) => _context = context;

        public Task<List<Cinema>> GetAllListAsync(CancellationToken cancellationToken)
        {
            return _context.Cinemas.ToListAsync(cancellationToken);
        }
    }
}
